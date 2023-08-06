namespace HideItWF
{
    partial class SignupForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.emailtbx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.firstnametbx = new System.Windows.Forms.TextBox();
            this.lastnametbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signupbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordtbx = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.usernametbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.repasswordtbx = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phonetbx = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(562, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "הרשמה";
            // 
            // emailtbx
            // 
            this.emailtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.emailtbx.Location = new System.Drawing.Point(464, 209);
            this.emailtbx.Name = "emailtbx";
            this.emailtbx.Size = new System.Drawing.Size(281, 26);
            this.emailtbx.TabIndex = 4;
            this.emailtbx.Validating += new System.ComponentModel.CancelEventHandler(this.Emailtbx_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(660, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "כתובת מייל";
            // 
            // firstnametbx
            // 
            this.firstnametbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstnametbx.Location = new System.Drawing.Point(607, 149);
            this.firstnametbx.Name = "firstnametbx";
            this.firstnametbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstnametbx.Size = new System.Drawing.Size(137, 26);
            this.firstnametbx.TabIndex = 1;
            this.firstnametbx.Validating += new System.ComponentModel.CancelEventHandler(this.Firstnametbx_Validating);
            // 
            // lastnametbx
            // 
            this.lastnametbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastnametbx.Location = new System.Drawing.Point(464, 149);
            this.lastnametbx.Name = "lastnametbx";
            this.lastnametbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastnametbx.Size = new System.Drawing.Size(138, 26);
            this.lastnametbx.TabIndex = 2;
            this.lastnametbx.Validating += new System.ComponentModel.CancelEventHandler(this.Lastnametbx_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(715, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "שם";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HideItWF.Properties.Resources.steps;
            this.pictureBox2.Location = new System.Drawing.Point(469, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 72);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HideItWF.Properties.Resources.pixmelogo;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // signupbtn
            // 
            this.signupbtn.Location = new System.Drawing.Point(567, 536);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(117, 28);
            this.signupbtn.TabIndex = 6;
            this.signupbtn.Text = "הרשם";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.Signupbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(651, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "אימות סיסמה";
            // 
            // passwordtbx
            // 
            this.passwordtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passwordtbx.Location = new System.Drawing.Point(465, 335);
            this.passwordtbx.Name = "passwordtbx";
            this.passwordtbx.PasswordChar = '*';
            this.passwordtbx.Size = new System.Drawing.Size(281, 26);
            this.passwordtbx.TabIndex = 2;
            this.passwordtbx.Validating += new System.ComponentModel.CancelEventHandler(this.Passwordtbx_Validaiting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(668, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "צור סיסמה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(672, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "מס\' טלפון";
            // 
            // usernametbx
            // 
            this.usernametbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.usernametbx.Location = new System.Drawing.Point(465, 269);
            this.usernametbx.Name = "usernametbx";
            this.usernametbx.Size = new System.Drawing.Size(281, 26);
            this.usernametbx.TabIndex = 1;
            this.usernametbx.Validating += new System.ComponentModel.CancelEventHandler(this.Usernametbx_Validaiting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(634, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "צור שם משתמש";
            // 
            // repasswordtbx
            // 
            this.repasswordtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.repasswordtbx.Location = new System.Drawing.Point(465, 397);
            this.repasswordtbx.Name = "repasswordtbx";
            this.repasswordtbx.PasswordChar = '*';
            this.repasswordtbx.Size = new System.Drawing.Size(281, 26);
            this.repasswordtbx.TabIndex = 3;
            this.repasswordtbx.Validating += new System.ComponentModel.CancelEventHandler(this.Repasswordtbx_Validaiting);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(589, 515);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 44;
            this.label9.Text = "כבר רשום?";
            // 
            // phonetbx
            // 
            this.phonetbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.phonetbx.Location = new System.Drawing.Point(471, 469);
            this.phonetbx.Mask = "(972) 000-000-000";
            this.phonetbx.Name = "phonetbx";
            this.phonetbx.PromptChar = ' ';
            this.phonetbx.Size = new System.Drawing.Size(275, 26);
            this.phonetbx.TabIndex = 45;
            this.phonetbx.Validating += new System.ComponentModel.CancelEventHandler(this.Phonetbx_Validating);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 585);
            this.Controls.Add(this.phonetbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastnametbx);
            this.Controls.Add(this.repasswordtbx);
            this.Controls.Add(this.firstnametbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailtbx);
            this.Controls.Add(this.usernametbx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordtbx);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupForm";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox emailtbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox firstnametbx;
        private System.Windows.Forms.TextBox lastnametbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox phonetbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox repasswordtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox passwordtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button signupbtn;
    }
}