using System;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace StudentAccessApplication
{
    public partial class Form3 : Form
    {
        private static string CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\opera\Submission_BOX\Pent@gle―就職活動報告システム\DB.mdb";
        public Form3()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
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

            dbCmd = new OleDbCommand(
            "insert into Teacher(MAIL) " +
            $"values('{newAddressText.Text}')", dbCon);
            dbCmd.ExecuteNonQuery();

            nowAddressText.Text = newAddressText.Text;


            MessageBox.Show("情報をPent@gleに登録しました。");
        }

        private void Form3_Load(object sender, EventArgs e)
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
                    nowAddressText.Text = num;
                    break;
                }
            }

            nowAddressText.ReadOnly = true;

        }

        private void AllviewButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();

            connection.ConnectionString = CONNECTION_STRING;
           
            command.CommandText = "SELECT * FROM ビューワー";
            command.Connection = connection;


            connection.Open();  // 接続します

            using (OleDbDataReader dr = command.ExecuteReader())
            {
                string[] msg = new string[1];
                for (int i = 0; dr.Read(); i++)
                {
                    string str1 = dr.GetString(1);
                    string str2 = dr.GetString(2);
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
                    msg[i] = string.Format("名前とID　　:{0}({1})\n日付　　　　:{2}\n事業所名　　:{3}\n選考状況　　:{4}" +
                        "\n時刻　　　　:{5}～{6}\n住所　　　　:{7}\n電話番号　　:{8}\n担当者名　　:{9}" +
                        "\n訪問その他　:{10}\n実施内容　　:{11}\nスケジュール:{12}\n備考　　　　:{13}",
                        str2, str1, str3, str4, str5, str6, str7, str8, str9, str13, str10, str11, str12, str14);
                    Array.Resize(ref msg, i + 2);
                }
                // それぞれの配列を\n区切りで結合する
                string msgM = string.Join("\n------------------------------------------------\n", msg);
                if (msgM.Equals(string.Empty))
                {
                    MessageBox.Show("条件に一致するデータが存在しません。", "検索結果");
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();

            connection.ConnectionString = CONNECTION_STRING;
            // command.CommandText = "SELECT * FROM ビューワー WHERE STUID =" + "'2019stu21'";
            // command.CommandText = "SELECT * FROM ビューワー WHERE STUID ='" + IDText.Text +"'";
            // command.CommandText = "SELECT * FROM ビューワー WHERE 日付 =" + "'2020/10/12'";
            // command.CommandText = "SELECT * FROM ビューワー WHERE 会社名 =" + "'カプセルコーポレーション'";
           
            command.CommandText = SQL_create(StuText,NameText,daytext,companyText);
            command.Connection = connection;

            connection.Open();  // 接続します

            using (OleDbDataReader dr = command.ExecuteReader())
            {
                string[] msg = new string[1];
                for (int i = 0; dr.Read(); i++)
                {
                    string str1 = dr.GetString(1);
                    string str2 = dr.GetString(2);
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
                    msg[i] = string.Format("名前とID　　:{0}({1})\n日付　　　　:{2}\n事業所名　　:{3}\n選考状況　　:{4}" +
                        "\n時刻　　　　:{5}～{6}\n住所　　　　:{7}\n電話番号　　:{8}\n担当者名　　:{9}" +
                        "\n訪問その他　:{10}\n実施内容　　:{11}\nスケジュール:{12}\n備考　　　　:{13}",
                        str2, str1, str3, str4, str5, str6, str7, str8, str9, str13, str10, str11, str12, str14);
                    Array.Resize(ref msg, i + 2);
                }
                // それぞれの配列を\n区切りで結合する
                string msgM = string.Join("\n------------------------------------------------\n", msg);
                if (msgM.Equals(string.Empty))
                {
                    MessageBox.Show("条件に一致するデータが存在しません。", "検索結果");
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

        static string SQL_create(TextBox stuText, TextBox nameText, MaskedTextBox DayText, TextBox companyText)
        {
            Boolean addflag = false;
            string SQLSentence = "SELECT * FROM ビューワー WHERE ";

            string addSentence = "";

            if (stuText.Text != string.Empty)
            {
                addSentence = $"STUID = '{stuText.Text}'";
                addflag = true;
            }

            if (nameText.Text != string.Empty)
            {
                if (addflag)
                {
                    addSentence = addSentence + $" AND 名前 like '%{nameText.Text}%'";
                }
                else
                {
                    addSentence = $"名前 like '%{nameText.Text}%'";
                    addflag = true;
                }

            }

            if (DayText.Text != string.Empty && DayText.Text != "    /  /")
            {
                if (addflag)
                {
                    addSentence = addSentence + $" AND 日付 = '{DayText.Text}'";
                }
                else
                {
                    addSentence = $"日付 = '{DayText.Text}'";
                    addflag = true;
                }

            }

            if (companyText.Text != string.Empty)
            {
                if (addflag)
                {
                    addSentence = addSentence + $" AND 会社名 like '%{companyText.Text}%'";
                }
                else
                {
                    addSentence = $"会社名 like '%{companyText.Text}%'";
                    addflag = true;
                }

            }

            if (addflag)
            {
                return SQLSentence + addSentence;
            }
            else {
                return "SELECT * FROM ビューワー";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }


}


