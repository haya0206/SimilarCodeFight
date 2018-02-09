namespace CodeFight
{
    partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.user1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.languege = new System.Windows.Forms.ComboBox();
			this.giveup = new System.Windows.Forms.Button();
			this.compileButton = new System.Windows.Forms.Button();
			this.compilerResultBox = new System.Windows.Forms.TextBox();
			this.questionBox = new System.Windows.Forms.TextBox();
			this.user2 = new System.Windows.Forms.Label();
			this.vsBox = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vsBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(461, 690);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "매칭중";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("나눔고딕코딩", 12F);
			this.textBox1.Location = new System.Drawing.Point(30, 95);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(650, 450);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "It is Test";
			// 
			// user1
			// 
			this.user1.AutoSize = true;
			this.user1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 20F, System.Drawing.FontStyle.Bold);
			this.user1.Location = new System.Drawing.Point(508, 30);
			this.user1.Name = "user1";
			this.user1.Size = new System.Drawing.Size(114, 38);
			this.user1.TabIndex = 3;
			this.user1.Text = "label2";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.vsBox);
			this.panel1.Controls.Add(this.languege);
			this.panel1.Controls.Add(this.giveup);
			this.panel1.Controls.Add(this.compileButton);
			this.panel1.Controls.Add(this.compilerResultBox);
			this.panel1.Controls.Add(this.questionBox);
			this.panel1.Controls.Add(this.user2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.user1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1000, 800);
			this.panel1.TabIndex = 4;
			// 
			// languege
			// 
			this.languege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.languege.Font = new System.Drawing.Font("나눔스퀘어", 15F);
			this.languege.FormattingEnabled = true;
			this.languege.Items.AddRange(new object[] {
            "C",
            "C++",
            "Java",
            "Python2",
            "Python3"});
			this.languege.Location = new System.Drawing.Point(30, 30);
			this.languege.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.languege.Name = "languege";
			this.languege.Size = new System.Drawing.Size(130, 35);
			this.languege.TabIndex = 9;
			// 
			// giveup
			// 
			this.giveup.Font = new System.Drawing.Font("나눔스퀘어", 15F);
			this.giveup.Location = new System.Drawing.Point(850, 25);
			this.giveup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.giveup.Name = "giveup";
			this.giveup.Size = new System.Drawing.Size(120, 50);
			this.giveup.TabIndex = 8;
			this.giveup.Text = "포기";
			this.giveup.UseVisualStyleBackColor = true;
			this.giveup.Click += new System.EventHandler(this.giveup_Click);
			// 
			// compileButton
			// 
			this.compileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.compileButton.Font = new System.Drawing.Font("나눔스퀘어", 25F);
			this.compileButton.Location = new System.Drawing.Point(710, 575);
			this.compileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.compileButton.Name = "compileButton";
			this.compileButton.Size = new System.Drawing.Size(260, 80);
			this.compileButton.TabIndex = 7;
			this.compileButton.Text = "컴파일";
			this.compileButton.UseVisualStyleBackColor = true;
			this.compileButton.Click += new System.EventHandler(this.compileButton_ClickAsync);
			// 
			// compilerResultBox
			// 
			this.compilerResultBox.Location = new System.Drawing.Point(30, 575);
			this.compilerResultBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.compilerResultBox.Multiline = true;
			this.compilerResultBox.Name = "compilerResultBox";
			this.compilerResultBox.ReadOnly = true;
			this.compilerResultBox.Size = new System.Drawing.Size(650, 195);
			this.compilerResultBox.TabIndex = 6;
			// 
			// questionBox
			// 
			this.questionBox.Font = new System.Drawing.Font("나눔고딕코딩", 12F);
			this.questionBox.Location = new System.Drawing.Point(710, 90);
			this.questionBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.questionBox.Multiline = true;
			this.questionBox.Name = "questionBox";
			this.questionBox.ReadOnly = true;
			this.questionBox.Size = new System.Drawing.Size(260, 450);
			this.questionBox.TabIndex = 5;
			this.questionBox.Text = "It is Test";
			// 
			// user2
			// 
			this.user2.AutoSize = true;
			this.user2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 20F, System.Drawing.FontStyle.Bold);
			this.user2.Location = new System.Drawing.Point(200, 30);
			this.user2.Name = "user2";
			this.user2.Size = new System.Drawing.Size(114, 38);
			this.user2.TabIndex = 4;
			this.user2.Text = "label2";
			// 
			// vsBox
			// 
			this.vsBox.Image = ((System.Drawing.Image)(resources.GetObject("vsBox.Image")));
			this.vsBox.Location = new System.Drawing.Point(350, 20);
			this.vsBox.Name = "vsBox";
			this.vsBox.Size = new System.Drawing.Size(122, 64);
			this.vsBox.TabIndex = 10;
			this.vsBox.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(330, 90);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(340, 550);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Image = global::CodeFight.Properties.Resources.dancing;
			this.pictureBox2.Location = new System.Drawing.Point(710, 655);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(65, 115);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Image = global::CodeFight.Properties.Resources.dancing;
			this.pictureBox3.Location = new System.Drawing.Point(775, 655);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(65, 115);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox4.Image = global::CodeFight.Properties.Resources.dancing;
			this.pictureBox4.Location = new System.Drawing.Point(840, 655);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(65, 115);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 11;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox5.Image = global::CodeFight.Properties.Resources.dancing;
			this.pictureBox5.Location = new System.Drawing.Point(905, 655);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(65, 115);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 11;
			this.pictureBox5.TabStop = false;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 800);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form2";
			this.Text = "Form2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
			this.Load += new System.EventHandler(this.Form2_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.vsBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label user1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label user2;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Button giveup;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.TextBox compilerResultBox;
        private System.Windows.Forms.ComboBox languege;
		private System.Windows.Forms.PictureBox vsBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}