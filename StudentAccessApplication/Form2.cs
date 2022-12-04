using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudentAccessApplication
{
    public partial class Form2 : Form
    {
        private static string CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\opera\Submission_BOX\Pent@gle―就職活動報告システム\DB.mdb";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StuIDRegistText.Text = Environment.UserName;
            StuIDRegistText.ReadOnly = true;
            this.ControlBox = !this.ControlBox;
        }

        private void RegistButton_Click(object sender, EventArgs e)
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
            "insert into 学生(STUID,名前) " +
            $"values('{StuIDRegistText.Text}','{nameText.Text}')", dbCon);
            dbCmd.ExecuteNonQuery();

            MessageBox.Show("情報をPent@gleに登録しました。", "登録通知");
            Close();
          
        }
    }
}
