using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Text;
using System.IO;

namespace StudentAccessApplication
{
    public partial class Form1 : Form
    {
        string sendDomein;
        string userName;
        private static string CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\opera\Submission_BOX\Pent@gle―就職活動報告システム\DB.mdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();


            connection.ConnectionString = CONNECTION_STRING;
            command.CommandText = $"SELECT 名前 FROM 学生 WHERE StuID = '{Environment.UserName}'";
            command.Connection = connection;

            connection.Open();  // 接続します

            using (OleDbDataReader dr = command.ExecuteReader())
            {
                for (int i = 0; dr.Read(); i++)
                {
                    userName = dr.GetString(0);
                }
            }

            command.CommandText = "SELECT * FROM Teacher ORDER BY ID DESC";
            command.Connection = connection;

            using (OleDbDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    string num = dr.GetString(1);
                    sendDomein = num;
                    break;
                }
            }

            IDText.Text = Environment.UserName;
            // DateTime dt = DateTime.Now;
            // DateText.Text = dt.ToShortDateString();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            IDText.ReadOnly = true;
            // DateText.ReadOnly = true;
            UserNameText.Text = userName;
            UserNameText.ReadOnly = true;
            
            PhaseText.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        class OutputWriter : System.IO.TextWriter
        {
            public override System.Text.Encoding Encoding
            {
                get { return null; }
            }

            public override void WriteLine(string value)
            {
                // ［出力］ウィンドウに表示
                System.Diagnostics.Debug.WriteLine(value);
            }
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();

            connection.ConnectionString = CONNECTION_STRING;
            // command.CommandText = "SELECT * FROM ビューワー WHERE STUID =" + "'2019stu21'";
            // command.CommandText = "SELECT * FROM ビューワー WHERE STUID ='" + IDText.Text +"'";
            // command.CommandText = "SELECT * FROM ビューワー WHERE 日付 =" + "'2020/10/12'";
            // command.CommandText = "SELECT * FROM ビューワー WHERE 会社名 =" + "'カプセルコーポレーション'";
            // command.CommandText = "SELECT * FROM ビューワー WHERE 会社名 ='" + CompanySearchText.Text + "'";
            if (CompanySearchText.Text == "")
            {
                command.CommandText = "SELECT * FROM ビューワー WHERE 日付 ='" + DateSearchText.Text + "'";
            }
            else if (DateSearchText.Text == "    /  /")
            {
                command.CommandText = "SELECT * FROM ビューワー WHERE 会社名 like '%"+CompanySearchText.Text+"%'";
            }
            else
            {
                command.CommandText = $"SELECT * FROM ビューワー WHERE 会社名 like '%{CompanySearchText.Text}%' AND 日付='{DateSearchText.Text}'";
            }
            command.Connection = connection;

            connection.Open();  // 接続します

            using (OleDbDataReader dr = command.ExecuteReader())
            {
                string[] msg = new string[1];
                for (int i = 0; dr.Read(); i++)
                {
                    string str1 = dr.GetString(1);
                    string str3 = dr.GetString(3);
                    string str4 = dr.GetString(4);
                    string str5 = dr.GetString(5);
                    string str6 = dr.GetString(6);
                    string str7 = dr.GetString(7);
                    string str8 = dr.GetString(8);
                    string str9 = dr.GetString(9);
                    string str10 = dr.GetString(10);
                    string str11 = dr.GetString(11);
                    string str12 = dr.GetString(12);
                    string str13 = dr.GetString(13);
                    string str14 = dr.GetString(14);
                    if (Convert.ToInt32(str1.Substring(0, 4)) < Convert.ToInt32(Environment.UserName.Substring(0, 4)) || Environment.UserName == str1)
                    {
                        msg[i] = string.Format("日付　　　　:{0}\n事業所名　　:{1}\n選考状況　　:{2}" +
                            "\n時刻　　　　:{3}～{4}\n住所　　　　:{5}\n電話番号　　:{6}\n担当者名　　:{7}" +
                            "\n訪問その他　:{8}\n実施内容　　:{9}\nスケジュール:{10}\n備考　　　　:{11}",
                            str3, str4, str5, str6, str7, str8, str9, str13, str10, str11, str12, str14);
                        Array.Resize(ref msg, i + 2);
                    }
                }
                // それぞれの配列を\n区切りで結合する
                string msgM = string.Join("\n------------------------------------------------\n", msg);
                if (msgM.Equals(string.Empty))
                {
                    MessageBox.Show("データが存在しません。", "検索結果");
                }
                else
                {
                    StreamWriter writer =
                      new StreamWriter(@"\\opera\Submission_BOX\Pent@gle―就職活動報告システム\" + Environment.UserName + "Print.txt", false, Encoding.UTF8);
                    writer.WriteLine(msgM);
                    writer.Close();
                    System.Diagnostics.Process.Start("Notepad", @"\\opera\Submission_BOX\Pent@gle―就職活動報告システム\" + Environment.UserName + "Print.txt");
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            OleDbConnection dbCon;
            OleDbCommand dbCmd;

            // ACCESS DB オープン
            dbCon = new OleDbConnection();
            String cst = "";
            cst = cst + "Provider=Microsoft.Jet.OLEDB.4.0;";
            cst = cst + "Data Source=" + CONNECTION_STRING;
            dbCon.ConnectionString = cst;
            dbCon.Open();

            if (CompanyText.Text.Equals(string.Empty) || PhaseText.Text.Equals(string.Empty) || DateText.Text == "    /  /"){
                MessageBox.Show("訪問日付・事業所名・訪問目的を入力してください。");
            }
            else {
                dbCmd = new OleDbCommand(
                    "insert into ビューワー(STUID,名前,日付,会社名,進捗状況,時刻A,時刻B,住所,電話番号,担当者名,訪問その他,実施内容,今後のスケジュール,備考) " +
                    $"values('{IDText.Text}','{UserNameText.Text}','{DateText.Text}','{CompanyText.Text}','{PhaseText.Text}'," +
                    $"'{TimeAText.Text}','{TimeBText.Text}','{AddressText.Text}','{PhoneNumberText.Text}','{AnotherPhaseText.Text}'," +
                    $"'{ImplementationText.Text}','{ScheduleText.Text}','{PersonChargeText.Text}','{RemarksText.Text}')", dbCon);
                dbCmd.ExecuteNonQuery();

                using (var client = new SmtpClient("smtp.nagoya-vti.ac.jp", 25))
                {
                    client.EnableSsl = false;
                    client.Send("Pent@gle", // From
                                $"{sendDomein}", // To
                                "Pent@gleシステム自動送信", // Subject
                                $"{Environment.UserName}が就職活動状況をPent@gleに登録しました。\n\n ※このメールは自動送信です。\n ※このメールは配信専用です。このメールに返信いただいても対応できません。");
                }
                MessageBox.Show("情報をPent@gleに登録しました。\n担当の指導員に登録した旨を口頭で報告してください。");
            }
        }

        private void DateText_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)  // 自分の状況
        {
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();

            connection.ConnectionString = CONNECTION_STRING;
            // command.CommandText = "SELECT * FROM ビューワー WHERE STUID =" + "'2019stu21'";
            command.CommandText = "SELECT * FROM ビューワー WHERE STUID ='" + IDText.Text +"'";
            // command.CommandText = "SELECT * FROM ビューワー WHERE 日付 =" + "'2020/10/12'";
            // command.CommandText = "SELECT * FROM ビューワー WHERE 会社名 =" + "'カプセルコーポレーション'";
            // command.CommandText = "SELECT * FROM ビューワー WHERE 会社名 ='" + CompanySearchText.Text + "'";
            // command.CommandText = "SELECT * FROM ビューワー WHERE 会社名 ='" + CompanySearchText.Text + "' AND 日付='" + DateSearchText.Text + "'";
            command.Connection = connection;

            connection.Open();  // 接続します

            using (OleDbDataReader dr = command.ExecuteReader()){
                string[] msg = new string[1];
                for (int i = 0; dr.Read(); i++)
                {
                    // int num0 = dr.GetInt32(0);
                    // string str1 = dr.GetString(1);
                    string str3 = dr.GetString(3);
                    string str4 = dr.GetString(4);
                    string str5 = dr.GetString(5);
                    string str6 = dr.GetString(6);
                    string str7 = dr.GetString(7);
                    string str8 = dr.GetString(8);
                    string str9 = dr.GetString(9);
                    string str10 = dr.GetString(10);
                    string str11 = dr.GetString(11);
                    string str12 = dr.GetString(12);
                    string str13 = dr.GetString(13);
                    string str14 = dr.GetString(14);
                    msg[i] = string.Format("日付　　　　:{0}\n事業所名　　:{1}\n選考状況　　:{2}" +
                        "\n時刻　　　　:{3}～{4}\n住所　　　　:{5}\n電話番号　　:{6}\n担当者名　　:{7}" +
                        "\n訪問その他　:{8}\n実施内容　　:{9}\nスケジュール:{10}\n備考　　　　:{11}", 
                        str3, str4, str5, str6, str7, str8, str9, str13, str10, str11, str12, str14);
                    Array.Resize(ref msg, i + 2);
                }
                // それぞれの配列を\n区切りで結合する
                string msgM = string.Join("\n------------------------------------------------\n", msg);
                if (msgM.Equals(string.Empty))
                {
                    MessageBox.Show("データが存在しません。", "検索結果");
                }
                else {
                    StreamWriter writer =
                    // new StreamWriter(@"\\opera\Submission_BOX\2019stu21\その他\Student.text", false, Encoding.UTF8);
                    new StreamWriter(@"\\opera\Submission_BOX\Pent@gle―就職活動報告システム\" + Environment.UserName + "Print.txt", false, Encoding.UTF8);
                    writer.WriteLine(msgM);
                    writer.Close();
                    System.Diagnostics.Process.Start("Notepad", @"\\opera\Submission_BOX\Pent@gle―就職活動報告システム\" + Environment.UserName + "Print.txt");
                }
                
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompanyText_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();

            connection.ConnectionString = CONNECTION_STRING;
            command.CommandText = "SELECT * FROM Teacher ORDER BY ID DESC";
            command.Connection = connection;

            connection.Open();  // 接続します

            using (OleDbDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    string num = dr.GetString(1);
                    MessageBox.Show(num);
                    break;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void CompanyLabel_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void PhaseText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DateText.ResetText();
            TimeAText.ResetText();
            TimeBText.ResetText();
            CompanyText.ResetText();
            AddressText.ResetText();
            PhoneNumberText.ResetText();
            PersonChargeText.ResetText();
            // ドロップダウンテキストは初期化できない、テキスト挿入も不可。
            PhaseText.ResetText();
            AnotherPhaseText.ResetText();
            ImplementationText.ResetText();
            ScheduleText.ResetText();
            RemarksText.ResetText();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

