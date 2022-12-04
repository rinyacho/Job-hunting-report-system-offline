namespace StudentAccessApplication
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newAddressText = new System.Windows.Forms.TextBox();
            this.nowAddressText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.daytext = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.companyText = new System.Windows.Forms.TextBox();
            this.StuText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AllviewButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.InsertButton);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.newAddressText);
            this.GroupBox.Controls.Add(this.nowAddressText);
            this.GroupBox.Location = new System.Drawing.Point(28, 31);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox.Size = new System.Drawing.Size(887, 210);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "入力";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(685, 130);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(4);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(100, 29);
            this.InsertButton.TabIndex = 5;
            this.InsertButton.Text = "登録";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "新しい報告先アドレス";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "現在の報告先アドレス";
            // 
            // newAddressText
            // 
            this.newAddressText.Location = new System.Drawing.Point(304, 134);
            this.newAddressText.Margin = new System.Windows.Forms.Padding(4);
            this.newAddressText.Name = "newAddressText";
            this.newAddressText.Size = new System.Drawing.Size(340, 22);
            this.newAddressText.TabIndex = 2;
            // 
            // nowAddressText
            // 
            this.nowAddressText.Location = new System.Drawing.Point(304, 55);
            this.nowAddressText.Margin = new System.Windows.Forms.Padding(4);
            this.nowAddressText.Name = "nowAddressText";
            this.nowAddressText.Size = new System.Drawing.Size(340, 22);
            this.nowAddressText.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.AllviewButton);
            this.groupBox2.Location = new System.Drawing.Point(28, 248);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(887, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出力";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.daytext);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.NameText);
            this.groupBox3.Controls.Add(this.companyText);
            this.groupBox3.Controls.Add(this.StuText);
            this.groupBox3.Controls.Add(this.SearchButton);
            this.groupBox3.Location = new System.Drawing.Point(328, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(532, 194);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(317, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 12;
            // 
            // daytext
            // 
            this.daytext.Location = new System.Drawing.Point(111, 87);
            this.daytext.Margin = new System.Windows.Forms.Padding(4);
            this.daytext.Mask = "0000/00/00";
            this.daytext.Name = "daytext";
            this.daytext.Size = new System.Drawing.Size(132, 22);
            this.daytext.TabIndex = 9;
            this.daytext.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "事業所名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "訪問日付";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "訓練生名";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "StuID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(324, 40);
            this.NameText.Margin = new System.Windows.Forms.Padding(4);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(170, 22);
            this.NameText.TabIndex = 4;
            // 
            // companyText
            // 
            this.companyText.Location = new System.Drawing.Point(324, 88);
            this.companyText.Margin = new System.Windows.Forms.Padding(4);
            this.companyText.Name = "companyText";
            this.companyText.Size = new System.Drawing.Size(170, 22);
            this.companyText.TabIndex = 3;
            // 
            // StuText
            // 
            this.StuText.Location = new System.Drawing.Point(111, 39);
            this.StuText.Margin = new System.Windows.Forms.Padding(4);
            this.StuText.Name = "StuText";
            this.StuText.Size = new System.Drawing.Size(132, 22);
            this.StuText.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(357, 140);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 29);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AllviewButton
            // 
            this.AllviewButton.Location = new System.Drawing.Point(65, 76);
            this.AllviewButton.Margin = new System.Windows.Forms.Padding(4);
            this.AllviewButton.Name = "AllviewButton";
            this.AllviewButton.Size = new System.Drawing.Size(190, 89);
            this.AllviewButton.TabIndex = 0;
            this.AllviewButton.Text = "生徒の状況全て";
            this.AllviewButton.UseVisualStyleBackColor = true;
            this.AllviewButton.Click += new System.EventHandler(this.AllviewButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 491);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(648, 60);
            this.label7.TabIndex = 5;
            this.label7.Text = "※このフォームは指導員専用です。\r\n※訓練生が登録した就職活動状況を検索・閲覧することができます。\r\n※訓練生が就職活動状況を入力した場合、上記に登録されたメール" +
    "アドレス宛に報告メールが送信されます。\r\n※検索時に訓練生の名前が表示されるのは指導員専用のフォームのみです。\r\n";
            // 
            // Form3
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(941, 577);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "PENT@GLE―就職活動報告システム　指導員入出力フォーム";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox newAddressText;
        private System.Windows.Forms.TextBox nowAddressText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox StuText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AllviewButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox companyText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox daytext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}