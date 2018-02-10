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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.user1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loseImage = new System.Windows.Forms.PictureBox();
            this.winImage = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vsBox = new System.Windows.Forms.PictureBox();
            this.languege = new System.Windows.Forms.ComboBox();
            this.giveup = new System.Windows.Forms.Button();
            this.compileButton = new System.Windows.Forms.Button();
            this.compilerResultBox = new System.Windows.Forms.TextBox();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.user2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(403, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "매칭중";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(26, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 361);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // user1
            // 
            this.user1.AutoSize = true;
            this.user1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 20F, System.Drawing.FontStyle.Bold);
            this.user1.Location = new System.Drawing.Point(444, 24);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(89, 30);
            this.user1.TabIndex = 3;
            this.user1.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loseImage);
            this.panel1.Controls.Add(this.winImage);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 640);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loseImage
            // 
            this.loseImage.Image = ((System.Drawing.Image)(resources.GetObject("loseImage.Image")));
            this.loseImage.Location = new System.Drawing.Point(326, 202);
            this.loseImage.Name = "loseImage";
            this.loseImage.Size = new System.Drawing.Size(261, 163);
            this.loseImage.TabIndex = 13;
            this.loseImage.TabStop = false;
            this.loseImage.Visible = false;
            // 
            // winImage
            // 
            this.winImage.Image = ((System.Drawing.Image)(resources.GetObject("winImage.Image")));
            this.winImage.Location = new System.Drawing.Point(326, 202);
            this.winImage.Name = "winImage";
            this.winImage.Size = new System.Drawing.Size(261, 163);
            this.winImage.TabIndex = 12;
            this.winImage.TabStop = false;
            this.winImage.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Image = global::CodeFight.Properties.Resources.dancing;
            this.pictureBox5.Location = new System.Drawing.Point(792, 524);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 92);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = global::CodeFight.Properties.Resources.dancing;
            this.pictureBox4.Location = new System.Drawing.Point(735, 524);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 92);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::CodeFight.Properties.Resources.dancing;
            this.pictureBox3.Location = new System.Drawing.Point(678, 524);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::CodeFight.Properties.Resources.dancing;
            this.pictureBox2.Location = new System.Drawing.Point(621, 524);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // vsBox
            // 
            this.vsBox.Image = ((System.Drawing.Image)(resources.GetObject("vsBox.Image")));
            this.vsBox.Location = new System.Drawing.Point(306, 16);
            this.vsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vsBox.Name = "vsBox";
            this.vsBox.Size = new System.Drawing.Size(107, 51);
            this.vsBox.TabIndex = 10;
            this.vsBox.TabStop = false;
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
            this.languege.Location = new System.Drawing.Point(26, 24);
            this.languege.Name = "languege";
            this.languege.Size = new System.Drawing.Size(114, 30);
            this.languege.TabIndex = 9;
            // 
            // giveup
            // 
            this.giveup.Font = new System.Drawing.Font("나눔스퀘어", 15F);
            this.giveup.Location = new System.Drawing.Point(744, 20);
            this.giveup.Name = "giveup";
            this.giveup.Size = new System.Drawing.Size(105, 40);
            this.giveup.TabIndex = 8;
            this.giveup.Text = "포기";
            this.giveup.UseVisualStyleBackColor = true;
            this.giveup.Click += new System.EventHandler(this.giveup_Click);
            // 
            // compileButton
            // 
            this.compileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.compileButton.Font = new System.Drawing.Font("나눔스퀘어", 25F);
            this.compileButton.Location = new System.Drawing.Point(621, 460);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(228, 64);
            this.compileButton.TabIndex = 7;
            this.compileButton.Text = "컴파일";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_ClickAsync);
            // 
            // compilerResultBox
            // 
            this.compilerResultBox.Location = new System.Drawing.Point(26, 460);
            this.compilerResultBox.Multiline = true;
            this.compilerResultBox.Name = "compilerResultBox";
            this.compilerResultBox.ReadOnly = true;
            this.compilerResultBox.Size = new System.Drawing.Size(569, 157);
            this.compilerResultBox.TabIndex = 6;
            // 
            // questionBox
            // 
            this.questionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.questionBox.Location = new System.Drawing.Point(621, 72);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.ReadOnly = true;
            this.questionBox.Size = new System.Drawing.Size(228, 361);
            this.questionBox.TabIndex = 5;
            // 
            // user2
            // 
            this.user2.AutoSize = true;
            this.user2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 20F, System.Drawing.FontStyle.Bold);
            this.user2.Location = new System.Drawing.Point(175, 24);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(89, 30);
            this.user2.TabIndex = 4;
            this.user2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 440);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(460, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox loseImage;
        private System.Windows.Forms.PictureBox winImage;
    }
}