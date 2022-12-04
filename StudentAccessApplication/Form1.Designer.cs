namespace StudentAccessApplication
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StuIDLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TimeBText = new System.Windows.Forms.MaskedTextBox();
            this.TimeAText = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.RemarksText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ScheduleText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ImplementationText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AnotherPhaseText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PersonChargeText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CompanyText = new System.Windows.Forms.TextBox();
            this.IDText = new System.Windows.Forms.MaskedTextBox();
            this.DateText = new System.Windows.Forms.MaskedTextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.PhaseLabel = new System.Windows.Forms.Label();
            this.PhaseText = new System.Windows.Forms.ComboBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OutputButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateSearchText = new System.Windows.Forms.MaskedTextBox();
            this.CompanySearchText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StuIDLabel
            // 
            this.StuIDLabel.AutoSize = true;
            this.StuIDLabel.Location = new System.Drawing.Point(391, 329);
            this.StuIDLabel.Name = "StuIDLabel";
            this.StuIDLabel.Size = new System.Drawing.Size(43, 15);
            this.StuIDLabel.TabIndex = 0;
            this.StuIDLabel.Text = "StuID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.TimeBText);
            this.groupBox1.Controls.Add(this.TimeAText);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.RemarksText);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.ScheduleText);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.ImplementationText);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.AnotherPhaseText);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.PersonChargeText);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.PhoneNumberText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AddressText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UserNameText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CompanyText);
            this.groupBox1.Controls.Add(this.IDText);
            this.groupBox1.Controls.Add(this.DateText);
            this.groupBox1.Controls.Add(this.SendButton);
            this.groupBox1.Controls.Add(this.PhaseLabel);
            this.groupBox1.Controls.Add(this.PhaseText);
            this.groupBox1.Controls.Add(this.StuIDLabel);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Controls.Add(this.CompanyLabel);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 368);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入力";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(300, 325);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 35;
            this.ClearButton.Text = "クリア";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(99, 303);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 12);
            this.label18.TabIndex = 34;
            this.label18.Text = "※入社への意向など特記事項を記載";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(99, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(295, 12);
            this.label17.TabIndex = 33;
            this.label17.Text = "※この後の採用試験、採用試験結果通知の日程などを記載";
            // 
            // TimeBText
            // 
            this.TimeBText.Location = new System.Drawing.Point(399, 31);
            this.TimeBText.Name = "TimeBText";
            this.TimeBText.Size = new System.Drawing.Size(104, 22);
            this.TimeBText.TabIndex = 32;
            this.TimeBText.ValidatingType = typeof(System.DateTime);
            // 
            // TimeAText
            // 
            this.TimeAText.Location = new System.Drawing.Point(272, 31);
            this.TimeAText.Name = "TimeAText";
            this.TimeAText.Size = new System.Drawing.Size(104, 22);
            this.TimeAText.TabIndex = 31;
            this.TimeAText.ValidatingType = typeof(System.DateTime);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(30, 333);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 15);
            this.label16.TabIndex = 30;
            this.label16.Text = "※●は必須入力事項です。";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // RemarksText
            // 
            this.RemarksText.Location = new System.Drawing.Point(96, 278);
            this.RemarksText.Name = "RemarksText";
            this.RemarksText.Size = new System.Drawing.Size(726, 22);
            this.RemarksText.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "備　　　　考";
            // 
            // ScheduleText
            // 
            this.ScheduleText.Location = new System.Drawing.Point(96, 226);
            this.ScheduleText.Name = "ScheduleText";
            this.ScheduleText.Size = new System.Drawing.Size(726, 22);
            this.ScheduleText.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "スケジュール";
            // 
            // ImplementationText
            // 
            this.ImplementationText.Location = new System.Drawing.Point(96, 169);
            this.ImplementationText.Name = "ImplementationText";
            this.ImplementationText.Size = new System.Drawing.Size(726, 22);
            this.ImplementationText.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "実 施 内 容";
            // 
            // AnotherPhaseText
            // 
            this.AnotherPhaseText.Location = new System.Drawing.Point(363, 124);
            this.AnotherPhaseText.Name = "AnotherPhaseText";
            this.AnotherPhaseText.Size = new System.Drawing.Size(459, 22);
            this.AnotherPhaseText.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "その他の訪問目的";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "先方担当者名";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // PersonChargeText
            // 
            this.PersonChargeText.Location = new System.Drawing.Point(666, 31);
            this.PersonChargeText.Name = "PersonChargeText";
            this.PersonChargeText.Size = new System.Drawing.Size(156, 22);
            this.PersonChargeText.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(597, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "電話番号";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Location = new System.Drawing.Point(666, 75);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(156, 22);
            this.PhoneNumberText.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "～";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "時刻";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "住所";
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(379, 76);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(205, 22);
            this.AddressText.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(99, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "※説明された内容、試験や面接の内容などを記載";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(600, 325);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(112, 22);
            this.UserNameText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "訓練生名";
            // 
            // CompanyText
            // 
            this.CompanyText.Location = new System.Drawing.Point(96, 75);
            this.CompanyText.Name = "CompanyText";
            this.CompanyText.Size = new System.Drawing.Size(223, 22);
            this.CompanyText.TabIndex = 8;
            this.CompanyText.TextChanged += new System.EventHandler(this.CompanyText_TextChanged);
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(436, 326);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(87, 22);
            this.IDText.TabIndex = 3;
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(96, 31);
            this.DateText.Mask = "0000/00/00";
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(109, 22);
            this.DateText.TabIndex = 4;
            this.DateText.ValidatingType = typeof(System.DateTime);
            this.DateText.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DateText_MaskInputRejected);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(735, 324);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "登録";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // PhaseLabel
            // 
            this.PhaseLabel.AutoSize = true;
            this.PhaseLabel.Location = new System.Drawing.Point(13, 128);
            this.PhaseLabel.Name = "PhaseLabel";
            this.PhaseLabel.Size = new System.Drawing.Size(82, 15);
            this.PhaseLabel.TabIndex = 3;
            this.PhaseLabel.Text = "●訪問目的";
            // 
            // PhaseText
            // 
            this.PhaseText.FormattingEnabled = true;
            this.PhaseText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PhaseText.Items.AddRange(new object[] {
            "一次選考",
            "二次選考",
            "三次選考",
            "四次選考",
            "内定",
            "不合格",
            "内定辞退",
            "説明会",
            "筆記試験",
            "その他"});
            this.PhaseText.Location = new System.Drawing.Point(96, 125);
            this.PhaseText.Name = "PhaseText";
            this.PhaseText.Size = new System.Drawing.Size(133, 23);
            this.PhaseText.TabIndex = 4;
            this.PhaseText.SelectedIndexChanged += new System.EventHandler(this.PhaseText_SelectedIndexChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(13, 34);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(82, 15);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "●訪問日付";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(13, 79);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(82, 15);
            this.CompanyLabel.TabIndex = 5;
            this.CompanyLabel.Text = "●事業所名";
            this.CompanyLabel.Click += new System.EventHandler(this.CompanyLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(28, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 156);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出力";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OutputButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.DateSearchText);
            this.groupBox3.Controls.Add(this.CompanySearchText);
            this.groupBox3.Location = new System.Drawing.Point(342, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 127);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // OutputButton
            // 
            this.OutputButton.Location = new System.Drawing.Point(393, 79);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(75, 23);
            this.OutputButton.TabIndex = 4;
            this.OutputButton.Text = "検索";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "訪問日付";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "事業所名";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateSearchText
            // 
            this.DateSearchText.Location = new System.Drawing.Point(86, 34);
            this.DateSearchText.Mask = "0000/00/00";
            this.DateSearchText.Name = "DateSearchText";
            this.DateSearchText.Size = new System.Drawing.Size(110, 22);
            this.DateSearchText.TabIndex = 10;
            this.DateSearchText.ValidatingType = typeof(System.DateTime);
            this.DateSearchText.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // CompanySearchText
            // 
            this.CompanySearchText.Location = new System.Drawing.Point(286, 34);
            this.CompanySearchText.Name = "CompanySearchText";
            this.CompanySearchText.Size = new System.Drawing.Size(182, 22);
            this.CompanySearchText.TabIndex = 12;
            this.CompanySearchText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 77);
            this.button1.TabIndex = 14;
            this.button1.Text = "自分の状況全て";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(483, 90);
            this.label4.TabIndex = 14;
            this.label4.Text = "※このフォームは訓練生専用です。\r\n※訓練生は自身のID（stu)でログインしたパソコンでのみ操作を行ってください。\r\n※訓練生は就職活動の状況をこのシステムを通" +
    "じて都度入力・登録してください。\r\n※登録が行われた旨は担当の指導員のメールアドレスへ自動で報告します。\r\n※過去の訓練生の就職活動状況を検索・閲覧することがで" +
    "きます。\r\n※誤った入力を行ってしまった場合は担当の指導員に報告してください。";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(914, 666);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.Text = "PENT@GLE―就職活動報告システム　訓練生入出力フォーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label StuIDLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PhaseLabel;
        private System.Windows.Forms.ComboBox PhaseText;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.TextBox CompanyText;
        private System.Windows.Forms.MaskedTextBox IDText;
        private System.Windows.Forms.MaskedTextBox DateText;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AnotherPhaseText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PersonChargeText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PhoneNumberText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox RemarksText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ScheduleText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ImplementationText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox TimeBText;
        private System.Windows.Forms.MaskedTextBox TimeAText;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox DateSearchText;
        private System.Windows.Forms.TextBox CompanySearchText;
    }
}

