Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq
Imports System.Data

Public Class AddressDataManager

    ' טבלת כתובות ציבורית לגישה מטפסים אחרים
    Public Shared AddressTable As DataTable
    Public autoComplete As New AutoCompleteStringCollection()
    ' פונקציה לטעינת נתונים מה-API ושמירתם ב-DataTable
    Public Sub LoadAddresses()
        If AddressTable IsNot Nothing Then Return ' אם כבר נטען - לא טוען שוב

        Dim url As String = "https://data.gov.il/api/3/action/datastore_search?resource_id=5c78e9fa-c2e2-4771-93ff-7f400a12f7ba"

        Try
            Using client As New WebClient()
                Dim bytes As Byte() = client.DownloadData(url)
                Dim json As String = Encoding.UTF8.GetString(bytes)

                Dim obj As JObject = JObject.Parse(json)
                Dim records As JArray = obj("result")("records")

                Dim dt As New DataTable()
                dt.Columns.Add("שם_ישוב")

                For Each record As JObject In records
                    If record("שם_ישוב") IsNot Nothing Then
                        Dim row As DataRow = dt.NewRow()
                        row("שם_ישוב") = record("שם_ישוב").ToString()
                        dt.Rows.Add(row)
                    End If
                Next

                Dim autoc As New AutoCompleteStringCollection

                For Each row As DataRow In dt.Rows
                    autoc.Add(row("שם_ישוב").ToString())
                Next

                autoComplete = autoc
            End Using

        Catch ex As Exception

            ' MessageBox.Show("שגיאה בעת טעינת כתובות: " & ex.Message)

            ' יצירת טבלה ריקה
            AddressTable = New DataTable()
            AddressTable.Columns.Add("שם_ישוב")

            ' רשימת ערכי ברירת מחדל במקרה של שגיאה
            Dim defaultCities As String() = {
    "אבו ג'ווייעד )שבט(", "אבו גוש", "אבו סנאן", "אבו סריחאן )שבט(", "אבו עבדון )שבט(", "אבו עמאר )שבט(", "אבו עמרה )שבט(", "אבו קורינאת )שבט(",
    "אבו קרינאת )יישוב(", "אבו רובייעה )שבט(", "אבו רוקייק )שבט(", "אבו תלול", "אבטין", "אבטליון", "אביאל", "אביבים", "אביגדור", "אביחיל",
    "אביטל", "אביעזר", "אבירים", "אבן יהודה", "אבן מנחם", "אבן ספיר", "אבן שמואל", "אבני איתן", "אבני חפץ", "אבנת", "אבשלום", "אדורה", "אדירים",
    "אדמית", "אדרת", "אודים", "אודם", "אוהד", "אום אל-פחם", "אום אל-קוטוף", "אום בטין", "אום ריחן", "אונו", "אור הגנוז", "אור הנר", "אור יהודה",
    "אור עקיבא", "אורטל", "אורנים", "אורנית", "אורים", "אורטל", "אושה", "אזור", "אזור תעשייה אכזיב מילואות", "אזור תעשייה אלון תבור",
    "אזור תעשייה בר לב", "אזור תעשייה מבואות הגלבוע", "אזור תעשייה מגדל תפן", "אזור תעשייה עמק חפר", "אזור תעשייה צבאים", "אזור תעשייה שער בנימין",
    "אזור תעשייה קרית אריה", "אזור תעשייה רמת גבריאל", "אחווה", "אחוזם", "אחוזת ברק", "אחיהוד", "אחיטוב", "אחיסמך", "אחיעזר", "אחמש",
    "אטרש )שבט(", "אייל", "איילת השחר", "איילת השחר", "איילון", "אילון", "אילניה", "אילת", "אימן", "אינדיאנה", "אפק", "אפעל", "אפיק",
    "אפיקים", "אפקה", "אפרת"
}

            Dim autoc As New AutoCompleteStringCollection
            For Each name As String In defaultCities
                AddressTable.Rows.Add(name)
                autoc.Add(name)
            Next
            autoComplete = autoc

        End Try


    End Sub

End Class
