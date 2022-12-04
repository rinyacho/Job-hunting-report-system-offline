using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StudentAccessApplication
{

    static class Program
    {
        private static string CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\opera\Submission_BOX\PENT@GLE―就職活動報告システム\DB.mdb";
        
        
        [STAThread]
        static void Main()
        {
           
            Boolean registflag = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            // Application.Run(new Form3());
            
            if (Environment.UserName.Contains("stu"))
            {
                //生徒の場合の処理
                OleDbConnection connection = new OleDbConnection();
                OleDbCommand command = new OleDbCommand();


                connection.ConnectionString = CONNECTION_STRING;
                command.CommandText = "SELECT StuID FROM 学生";
                command.Connection = connection;

                connection.Open();  // 接続します

                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    for (int i = 0; dr.Read(); i++)
                    {
                        string num1 = dr.GetString(0);

                        if (Environment.UserName == num1)
                        {
                            //ユーザーが登録されている場合
                            registflag = false;
                        }
                    }
                }

                if (registflag)
                {
                    //登録用フォームを開く
                    Application.Run(new Form2());
                }

                Application.Run(new Form1());

            } else if (Environment.UserName.Contains("inst")) {
                //教師の場合
                Application.Run(new Form3());
            }
            else {
                //教師でも生徒でもない場合
                MessageBox.Show("適切なユーザーでログインしてください。","エラー");
            }
        }
    }
}