<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewAccount))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox_AccountID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.05634!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.94366!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_AccountID, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(431, 222)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TextBox_AccountID
        '
        Me.TextBox_AccountID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox_AccountID.Location = New System.Drawing.Point(3, 130)
        Me.TextBox_AccountID.Name = "TextBox_AccountID"
        Me.TextBox_AccountID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox_AccountID.Size = New System.Drawing.Size(321, 29)
        Me.TextBox_AccountID.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "שם מלא"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(330, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "מס' טלפון"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(330, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "כתובת"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.Location = New System.Drawing.Point(3, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(321, 29)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox2.Location = New System.Drawing.Point(3, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox2.Size = New System.Drawing.Size(321, 29)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox3.AutoCompleteCustomSource.AddRange(New String() {"אבו ג'ווייעד )שבט(", "אבו גוש", "אבו סנאן", "אבו סריחאן )שבט(", "אבו עבדון )שבט(", "אבו עמאר )שבט(", "אבו עמרה )שבט(", "אבו קורינאת )שבט(", "אבו קרינאת )יישוב(", "אבו רובייעה )שבט(", "אבו רוקייק )שבט(", "אבו תלול", "אבטין", "אבטליון", "אביאל", "אביבים", "אביגדור", "אביחיל", "אביטל", "אביעזר", "אבירים", "אבן יהודה", "אבן מנחם", "אבן ספיר", "אבן שמואל", "אבני איתן", "אבני חפץ", "אבנת", "אבשלום", "אדורה", "אדירים", "אדמית", "אדרת", "אודים", "אודם", "אוהד", "אום אל-פחם", "אום אל-קוטוף", "אום בטין", "אומן", "אומץ", "אופקים", "אור הגנוז", "אור הנר", "אור יהודה", "אור עקיבא", "אורה", "אורות", "אורטל", "אורים", "אורנים", "אורנית", "אושה", "אזור", "אחווה", "אחוזם", "אחוזת ברק", "אחיהוד", "אחיטוב", "אחיסמך", "אחיעזר", "אטרש )שבט(", "איבים", "אייל", "איילת השחר", "אילון", "אילות", "אילניה", "אילת", "אירוס", "איתמר", "איתן", "איתנים", "אכסאל", "אל סייד", "אל-עזי", "אל-עריאן", "אל-רום", "אלומה", "אלומות", "אלון הגליל", "אלון מורה", "אלון שבות", "אלוני אבא", "אלוני הבשן", "אלוני יצחק", "אלונים", "אלי-עד", "אליאב", "אליכין", "אליפז", "אליפלט", "אליקים", "אלישיב", "אלישמע", "אלמגור", "אלמוג", "אלעד", "אלעזר", "אלפי מנשה", "אלקוש", "אלקנה", "אמונים", "אמירים", "אמנון", "אמציה", "אניעם", "אסד )שבט(", "אספר", "אעבלין", "אעצם )שבט(", "אפיניש )שבט(", "אפיק", "אפיקים", "אפק", "אפרת", "ארבל", "ארגמן", "ארז", "אריאל", "ארסוף", "אשבול", "אשבל", "אשדוד", "אשדות יעקב  )איחוד(", "אשדות יעקב  )מאוחד(", "אשחר", "אשכולות", "אשל הנשיא", "אשלים", "אשקלון", "אשרת", "אשתאול", "אתגר", "באקה אל-גרביה", "באר אורה", "באר גנים", "באר טוביה", "באר יעקב", "באר מילכה", "באר שבע", "בארות יצחק", "בארותיים", "בארי", "בוסתן הגליל", "בועיינה-נוג'ידאת", "בוקעאתא", "בורגתה", "בחן", "בטחה", "ביצרון", "ביר אל-מכסור", "ביר הדאג'", "ביריה", "בית אורן", "בית אל", "בית אלעזרי", "בית אלפא", "בית אריה", "בית ברל", "בית ג'ן", "בית גוברין", "בית גמליאל", "בית דגן", "בית הגדי", "בית הלוי", "בית הלל", "בית העמק", "בית הערבה", "בית השיטה", "בית זיד", "בית זית", "בית זרע", "בית חורון", "בית חירות", "בית חלקיה", "בית חנן", "בית חנניה", "בית חשמונאי", "בית יהושע", "בית יוסף", "בית ינאי", "בית יצחק-שער חפר", "בית לחם הגלילית", "בית מאיר", "בית נחמיה", "בית ניר", "בית נקופה", "בית עובד", "בית עוזיאל", "בית עזרא", "בית עריף", "בית צבי", "בית קמה", "בית קשת", "בית רבן", "בית רימון", "בית שאן", "בית שמש", "בית שערים", "בית שקמה", "ביתן אהרן", "ביתר עילית", "בלפוריה", "בן זכאי", "בן עמי", "בן שמן )כפר נוער(", "בן שמן )מושב(", "בני ברק", "בני דקלים", "בני דרום", "בני דרור", "בני יהודה", "בני נצרים", "בני עטרות", "בני עי""ש", "בני ציון", "בני ראם", "בניה", "בנימינה-גבעת עדה", "בסמ""ה", "בסמת טבעון", "בענה", "בצרה", "בצת", "בקוע", "בקעות", "בר גיורא", "בר יוחאי", "ברוכין", "ברור חיל", "ברוש", "ברכה", "ברכיה", "ברעם", "ברק", "ברקאי", "ברקן", "ברקת", "בת הדר", "בת חן", "בת חפר", "בת חצור", "בת ים", "בת עין", "בת שלמה", "ג'דיידה-מכר", "ג'ולס", "ג'לג'וליה", "ג'נאביב )שבט(", "ג'סר א-זרקא", "ג'ש )גוש חלב(", "ג'ת", "גאולי תימן", "גאולים", "גאליה", "גבולות", "גבים", "גבע", "גבע בנימין", "גבע כרמל", "גבעולים", "גבעון החדשה", "גבעות בר", "גבעת אבני", "גבעת אלה", "גבעת ברנר", "גבעת השלושה", "גבעת זאב", "גבעת ח""ן", "גבעת חיים )איחוד(", "גבעת חיים )מאוחד(", "גבעת יואב", "גבעת יערים", "גבעת ישעיהו", "גבעת כ""ח", "גבעת ניל""י", "גבעת עוז", "גבעת שמואל", "גבעת שמש", "גבעת שפירא", "גבעתי", "גבעתיים", "גברעם", "גבת", "גדות", "גדיש", "גדעונה", "גדרה", "גונן", "גורן", "גורנות הגליל", "גזית", "גזר", "גיאה", "גיבתון", "גיזו", "גילון", "גילת", "גינוסר", "גיניגר", "גינתון", "גיתה", "גיתית", "גלאון", "גלגל", "גליל ים", "גלעד )אבן יצחק(", "גמזו", "גן הדרום", "גן השומרון", "גן חיים", "גן יאשיה", "גן יבנה", "גן נר", "גן שורק", "גן שלמה", "גן שמואל", "גנות", "גנות הדר", "גני הדר", "גני טל", "גני יוחנן", "גני מודיעין", "גני עם", "גני תקווה", "געש", "געתון", "גפן", "גרופית", "גשור", "גשר", "גשר הזיו", "גת )קיבוץ(", "גת רימון", "דאלית אל-כרמל", "דבורה", "דבוריה", "דבירה", "דברת", "דגניה א'", "דגניה ב'", "דוב""ב", "דולב", "דור", "דורות", "דחי", "דייר אל-אסד", "דייר חנא", "דייר ראפאת", "דימונה", "דישון", "דליה", "דלתון", "דמיידה", "דן", "דפנה", "דקל", "דריג'את", "האון", "הבונים", "הגושרים", "הדר עם", "הוד השרון", "הודיה", "הודיות", "הוואשלה )שבט(", "הוזייל )שבט(", "הושעיה", "הזורע", "הזורעים", "החותרים", "היוגב", "הילה", "המעפיל", "הסוללים", "העוגן", "הר אדר", "הר גילה", "הר עמשא", "הראל", "הרדוף", "הרצליה", "הררית", "ורד יריחו", "ורדון", "זבארגה )שבט(", "זבדיאל", "זוהר", "זיקים", "זיתן", "זכרון יעקב", "זכריה", "זמר", "זמרת", "זנוח", "זרועה", "זרזיר", "זרחיה", "ח'ואלד", "ח'ואלד )שבט(", "חבצלת השרון", "חבר", "חברון", "חגור", "חגי", "חגלה", "חד-נס", "חדיד", "חדרה", "חוג'ייראת )ד'הרה(", "חולדה", "חולון", "חולית", "חולתה", "חוסן", "חוסנייה", "חופית", "חוקוק", "חורה", "חורפיש", "חורשים", "חזון", "חיבת ציון", "חיננית", "חיפה", "חירות", "חלוץ", "חלץ", "חמאם", "חמד", "חמדיה", "חמדת", "חמרה", "חניאל", "חניתה", "חנתון", "חספין", "חפץ חיים", "חפצי-בה", "חצב", "חצבה", "חצור הגלילית", "חצור-אשדוד", "חצר בארותיים", "חצרות חולדה", "חצרות יסף", "חצרות כ""ח", "חצרים", "חרב לאת", "חרוצים", "חריש", "חרמש", "חרשים", "חשמונאים", "טבריה", "טובא-זנגריה", "טורעאן", "טייבה", "טייבה )בעמק(", "טירה", "טירת יהודה", "טירת כרמל", "טירת צבי", "טל שחר", "טל-אל", "טללים", "טלמון", "טמרה", "טמרה )יזרעאל(", "טנא", "טפחות", "יאנוח-ג'ת", "יבול", "יבנאל", "יבנה", "יגור", "יגל", "יד בנימין", "יד השמונה", "יד חנה", "יד מרדכי", "יד נתן", "יד רמב""ם", "ידידה", "יהוד-מונוסון", "יהל", "יובל", "יובלים", "יודפת", "יונתן", "יושיביה", "יזרעאל", "יחיעם", "יטבתה", "ייט""ב", "יכיני", "ינוב", "ינון", "יסוד המעלה", "יסודות", "יסעור", "יעד", "יעל", "יעף", "יערה", "יפיע", "יפית", "יפעת", "יפתח", "יצהר", "יציץ", "יקום", "יקיר", "יקנעם )מושבה(", "יקנעם עילית", "יראון", "ירדנה", "ירוחם", "ירושלים", "ירחיב", "ירכא", "ירקונה", "ישע", "ישעי", "ישרש", "יתד", "יתיר", "כאבול", "כאוכב אבו אל-היג'א", "כברי", "כדורי", "כדיתה", "כוכב השחר", "כוכב יאיר", "כוכב יעקב", "כוכב מיכאל", "כורזים", "כחל", "כחלה", "כיסופים", "כישור", "כליל", "כלנית", "כמאנה", "כמהין", "כמון", "כנות", "כנף", "כנרת )מושבה(", "כנרת )קבוצה(", "כסיפה", "כסלון", "כסרא-סמיע", "כעביה-טבאש-חג'אג'רה", "כפר אביב", "כפר אדומים", "כפר אוריה", "כפר אחים", "כפר ביאליק", "כפר ביל""ו", "כפר בלום", "כפר בן נון", "כפר ברא", "כפר ברוך", "כפר גדעון", "כפר גלים", "כפר גליקסון", "כפר גלעדי", "כפר דניאל", "כפר האורנים", "כפר החורש", "כפר המכבי", "כפר הנגיד", "כפר הנוער הדתי", "כפר הנשיא", "כפר הס", "כפר הרא""ה", "כפר הרי""ף", "כפר ויתקין", "כפר ורבורג", "כפר ורדים", "כפר זוהרים", "כפר זיתים", "כפר חב""ד", "כפר חושן", "כפר חיטים", "כפר חיים", "כפר חנניה", "כפר חסידים א'", "כפר חסידים ב'", "כפר חרוב", "כפר טרומן", "כפר יאסיף", "כפר ידידיה", "כפר יהושע", "כפר יונה", "כפר יחזקאל", "כפר יעבץ", "כפר כמא", "כפר כנא", "כפר מונש", "כפר מימון", "כפר מל""ל", "כפר מנדא", "כפר מנחם", "כפר מסריק", "כפר מצר", "כפר מרדכי", "כפר נטר", "כפר סאלד", "כפר סבא", "כפר סילבר", "כפר סירקין", "כפר עבודה", "כפר עזה", "כפר עציון", "כפר פינס", "כפר קאסם", "כפר קיש", "כפר קרע", "כפר ראש הנקרה", "כפר רוזנואלד )זרעית(", "כפר רופין", "כפר רות", "כפר שמאי", "כפר שמואל", "כפר שמריהו", "כפר תבור", "כפר תפוח", "כרי דשא", "כרכום", "כרם בן זמרה", "כרם בן שמן", "כרם יבנה )ישיבה(", "כרם מהר""ל", "כרם שלום", "כרמי יוסף", "כרמי צור", "כרמי קטיף", "כרמיאל", "כרמיה", "כרמים", "כרמל", "לא רשום", "לבון", "לביא", "לבנים", "להב", "להבות הבשן", "להבות חביבה", "להבים", "לוד", "לוזית", "לוחמי הגיטאות", "לוטם", "לוטן", "לימן", "לכיש", "לפיד", "לפידות", "לקיה", "מאור", "מאיר שפיה", "מבוא ביתר", "מבוא דותן", "מבוא חורון", "מבוא חמה", "מבוא מודיעים", "מבואות ים", "מבועים", "מבטחים", "מבקיעים", "מבשרת ציון", "מג'ד אל-כרום", "מג'דל שמס", "מגאר", "מגדים", "מגדל", "מגדל העמק", "מגדל עוז", "מגדלים", "מגידו", "מגל", "מגן", "מגן שאול", "מגשימים", "מדרך עוז", "מדרשת בן גוריון", "מדרשת רופין", "מודיעין עילית", "מודיעין-מכבים-רעות", "מולדת", "מוצא עילית", "מוקייבלה", "מורן", "מורשת", "מזור", "מזכרת בתיה", "מזרע", "מזרעה", "מחולה", "מחנה הילה", "מחנה טלי", "מחנה יהודית", "מחנה יוכבד", "מחנה יפה", "מחנה יתיר", "מחנה מרים", "מחנה תל נוף", "מחניים", "מחסיה", "מטולה", "מטע", "מי עמי", "מיטב", "מייסר", "מיצר", "מירב", "מירון", "מישר", "מיתר", "מכורה", "מכחול", "מכמורת", "מכמנים", "מלאה", "מלילות", "מלכיה", "מלכישוע", "מנוחה", "מנוף", "מנות", "מנחמיה", "מנרה", "מנשית זבדה", "מסד", "מסדה", "מסילות", "מסילת ציון", "מסלול", "מסעדה", "מסעודין אל-עזאזמה", "מעברות", "מעגלים", "מעגן", "מעגן מיכאל", "מעוז חיים", "מעון", "מעונה", "מעיליא", "מעין ברוך", "מעין צבי", "מעלה אדומים", "מעלה אפרים", "מעלה גלבוע", "מעלה גמלא", "מעלה החמישה", "מעלה לבונה", "מעלה מכמש", "מעלה עירון", "מעלה עמוס", "מעלה שומרון", "מעלות-תרשיחא", "מענית", "מעש", "מפלסים", "מצדות יהודה", "מצובה", "מצליח", "מצפה", "מצפה אבי""ב", "מצפה אילן", "מצפה יריחו", "מצפה נטופה", "מצפה רמון", "מצפה שלם", "מצר", "מקווה ישראל", "מרגליות", "מרום גולן", "מרחב עם", "מרחביה )מושב(", "מרחביה )קיבוץ(", "מרכז שפירא", "משאבי שדה", "משגב דב", "משגב עם", "משהד", "משואה", "משואות יצחק", "משכיות", "משמר איילון", "משמר דוד", "משמר הירדן", "משמר הנגב", "משמר העמק", "משמר השבעה", "משמר השרון", "משמרות", "משמרת", "משען", "מתן", "מתת", "מתתיהו", "נאות גולן", "נאות הכיכר", "נאות מרדכי", "נאות סמדר", "נאעורה", "נבטים", "נגבה", "נגוהות", "נהורה", "נהלל", "נהריה", "נוב", "נוגה", "נוה צוף", "נווה", "נווה אבות", "נווה אור", "נווה אטי""ב", "נווה אילן", "נווה איתן", "נווה דניאל", "נווה זוהר", "נווה זיו", "נווה חריף", "נווה ים", "נווה ימין", "נווה ירק", "נווה מבטח", "נווה מיכאל", "נווה שלום", "נועם", "נוף איילון", "נופים", "נופית", "נופך", "נוקדים", "נורדיה", "נורית", "נחושה", "נחל עוז", "נחלה", "נחליאל", "נחלים", "נחם", "נחף", "נחשולים", "נחשון", "נחשונים", "נטועה", "נטור", "נטע", "נטעים", "נטף", "ניין", "ניל""י", "ניצן", "ניצן ב'", "ניצנה )קהילת חינוך(", "ניצני סיני", "ניצני עוז", "ניצנים", "ניר אליהו", "ניר בנים", "ניר גלים", "ניר דוד )תל עמל(", "ניר ח""ן", "ניר יפה", "ניר יצחק", "ניר ישראל", "ניר משה", "ניר עוז", "ניר עם", "ניר עציון", "ניר עקיבא", "ניר צבי", "נירים", "נירית", "נמרוד", "נס הרים", "נס עמים", "נס ציונה", "נעורים", "נעלה", "נעמ""ה", "נען", "נערן", "נצאצרה )שבט(", "נצר חזני", "נצר סרני", "נצרת", "נצרת עילית", "נשר", "נתיב הגדוד", "נתיב הל""ה", "נתיב העשרה", "נתיב השיירה", "נתיבות", "נתניה", "סאג'ור", "סאסא", "סביון", "סגולה", "סואעד )חמרייה(", "סואעד )כמאנה( )שבט(", "סולם", "סוסיה", "סופה", "סח'נין", "סייד )שבט(", "סלמה", "סלעית", "סמר", "סנסנה", "סעד", "סעוה", "סער", "ספיר", "סתריה", "ע'ג'ר", "עבדון", "עברון", "עגור", "עדי", "עדנים", "עוזה", "עוזייר", "עולש", "עומר", "עופר", "עופרה", "עוצם", "עוקבי )בנו עוקבה(", "עזוז", "עזר", "עזריאל", "עזריה", "עזריקם", "עטאוונה )שבט(", "עטרת", "עידן", "עיילבון", "עיינות", "עילוט", "עין איילה", "עין אל-אסד", "עין גב", "עין גדי", "עין דור", "עין הבשור", "עין הוד", "עין החורש", "עין המפרץ", "עין הנצי""ב", "עין העמק", "עין השופט", "עין השלושה", "עין ורד", "עין זיוון", "עין חוד", "עין חצבה", "עין חרוד )איחוד(", "עין חרוד )מאוחד(", "עין יהב", "עין יעקב", "עין כרם-בי""ס חקלאי", "עין כרמל", "עין מאהל", "עין נקובא", "עין עירון", "עין צורים", "עין קנייא", "עין ראפה", "עין שמר", "עין שריד", "עין תמר", "עינת", "עיר אובות", "עכו", "עלומים", "עלי", "עלי זהב", "עלמה", "עלמון", "עמוקה", "עמיחי", "עמינדב", "עמיעד", "עמיעוז", "עמיקם", "עמיר", "עמנואל", "עמקה", "ענב", "עספיא", "עפולה", "עץ אפרים", "עצמון שגב", "עראבה", "עראמשה", "ערב אל נעים", "ערד", "ערוגות", "ערערה", "ערערה-בנגב", "עשרת", "עתלית", "עתניאל", "פארן", "פדואל", "פדויים", "פדיה", "פוריה - כפר עבודה", "פוריה - נווה עובד", "פוריה עילית", "פוריידיס", "פורת", "פטיש", "פלך", "פלמחים", "פני חבר", "פסגות", "פסוטה", "פעמי תש""ז", "פצאל", "פקיעין )בוקייעה(", "פקיעין חדשה", "פרדס חנה-כרכור", "פרדסיה", "פרוד", "פרזון", "פרי גן", "פתח תקווה", "פתחיה", "צאלים", "צביה", "צבעון", "צובה", "צוחר", "צופיה", "צופים", "צופית", "צופר", "צוקי ים", "צוקים", "צור הדסה", "צור יצחק", "צור משה", "צור נתן", "צוריאל", "צורית", "ציפורי", "צלפון", "צנדלה", "צפריה", "צפרירים", "צפת", "צרופה", "צרעה", "קבועה )שבט(", "קבוצת יבנה", "קדומים", "קדימה-צורן", "קדמה", "קדמת צבי", "קדר", "קדרון", "קדרים", "קודייראת א-צאנע)שבט(", "קוואעין )שבט(", "קוממיות", "קורנית", "קטורה", "קיסריה", "קלחים", "קליה", "קלנסווה", "קלע", "קציר", "קצר א-סר", "קצרין", "קרית אונו", "קרית ארבע", "קרית אתא", "קרית ביאליק", "קרית גת", "קרית טבעון", "קרית ים", "קרית יערים", "קרית יערים)מוסד(", "קרית מוצקין", "קרית מלאכי", "קרית נטפים", "קרית ענבים", "קרית עקרון", "קרית שלמה", "קרית שמונה", "קרני שומרון", "קשת", "ראמה", "ראס אל-עין", "ראס עלי", "ראש העין", "ראש פינה", "ראש צורים", "ראשון לציון", "רבבה", "רבדים", "רביבים", "רביד", "רגבה", "רגבים", "רהט", "רווחה", "רוויה", "רוח מדבר", "רוחמה", "רומאנה", "רומת הייב", "רועי", "רותם", "רחוב", "רחובות", "רחלים", "ריחאניה", "ריחן", "ריינה", "רימונים", "רינתיה", "רכסים", "רם-און", "רמות", "רמות השבים", "רמות מאיר", "רמות מנשה", "רמות נפתלי", "רמלה", "רמת גן", "רמת דוד", "רמת הכובש", "רמת השופט", "רמת השרון", "רמת יוחנן", "רמת ישי", "רמת מגשימים", "רמת צבי", "רמת רזיאל", "רמת רחל", "רנן", "רעים", "רעננה", "רקפת", "רשפון", "רשפים", "רתמים", "שאר ישוב", "שבי דרום", "שבי ציון", "שבי שומרון", "שבלי - אום אל-גנם", "שגב-שלום", "שדה אילן", "שדה אליהו", "שדה אליעזר", "שדה בוקר", "שדה דוד", "שדה ורבורג", "שדה יואב", "שדה יעקב", "שדה יצחק", "שדה משה", "שדה נחום", "שדה נחמיה", "שדה ניצן", "שדה עוזיהו", "שדה צבי", "שדות ים", "שדות מיכה", "שדי אברהם", "שדי חמד", "שדי תרומות", "שדמה", "שדמות דבורה", "שדמות מחולה", "שדרות", "שואבה", "שובה", "שובל", "שוהם", "שומרה", "שומריה", "שוקדה", "שורש", "שורשים", "שושנת העמקים", "שזור", "שחר", "שחרות", "שיבולים", "שיטים", "שייח' דנון", "שילה", "שילת", "שכניה", "שלווה", "שלווה במדבר", "שלוחות", "שלומי", "שלומית", "שמיר", "שמעה", "שמרת", "שמשית", "שני", "שניר", "שעב", "שעורים", "שעל", "שעלבים", "שער אפרים", "שער הגולן", "שער העמקים", "שער מנשה", "שערי תקווה", "שפיים", "שפיר", "שפר", "שפרעם", "שקד", "שקף", "שרונה", "שריגים )לי-און(", "שריד", "שרשרת", "שתולה", "שתולים", "תאשור", "תדהר", "תובל", "תומר", "תושיה", "תימורים", "תירוש", "תל אביב - יפו", "תל יוסף", "תל יצחק", "תל מונד", "תל עדשים", "תל קציר", "תל שבע", "תל תאומים", "תלם", "תלמי אליהו", "תלמי אלעזר", "תלמי ביל""ו", "תלמי יוסף", "תלמי יחיאל", "תלמי יפה", "תלמים", "תמרת", "תנובות", "תעוז", "תפרח", "תקומה", "תקוע", "תראבין א-צאנע )שבט(", "תראבין א-צאנע)ישוב(", "תרום"})
        Me.TextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox3.Location = New System.Drawing.Point(3, 85)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox3.Size = New System.Drawing.Size(321, 29)
        Me.TextBox3.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(3, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "הוסף / עדכן"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(330, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ת.זהות"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddNewAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 222)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddNewAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "פרטי לקוח"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox_AccountID As TextBox
    Friend WithEvents Label4 As Label
End Class
