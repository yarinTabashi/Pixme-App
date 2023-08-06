namespace HideItWF
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.goToUpcoming = new System.Windows.Forms.Button();
            this.goToWaiting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.offerMeBtn = new System.Windows.Forms.Button();
            this.gotoeditprofitolobtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.dontwanteventslabel = new System.Windows.Forms.Label();
            this.upcomingeventslabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.daysLeftCloselabel = new System.Windows.Forms.Label();
            this.getdetbtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.noeventsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.goToUploadFormBtn = new System.Windows.Forms.Button();
            this.profilepbx = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.noeventsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepbx)).BeginInit();
            this.SuspendLayout();
            // 
            // goToUpcoming
            // 
            this.goToUpcoming.Location = new System.Drawing.Point(25, 202);
            this.goToUpcoming.Name = "goToUpcoming";
            this.goToUpcoming.Size = new System.Drawing.Size(188, 45);
            this.goToUpcoming.TabIndex = 0;
            this.goToUpcoming.Text = "רשימת האירועים";
            this.goToUpcoming.UseVisualStyleBackColor = true;
            this.goToUpcoming.Click += new System.EventHandler(this.GoToUpComing_Click);
            // 
            // goToWaiting
            // 
            this.goToWaiting.Location = new System.Drawing.Point(25, 290);
            this.goToWaiting.Name = "goToWaiting";
            this.goToWaiting.Size = new System.Drawing.Size(188, 41);
            this.goToWaiting.TabIndex = 2;
            this.goToWaiting.Text = "ממתינים לאישור";
            this.goToWaiting.UseVisualStyleBackColor = true;
            this.goToWaiting.Click += new System.EventHandler(this.GoToWaiting_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.offerMeBtn);
            this.panel1.Controls.Add(this.gotoeditprofitolobtn);
            this.panel1.Controls.Add(this.goToUpcoming);
            this.panel1.Controls.Add(this.goToWaiting);
            this.panel1.Controls.Add(this.profilepbx);
            this.panel1.Location = new System.Drawing.Point(808, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 526);
            this.panel1.TabIndex = 4;
            // 
            // offerMeBtn
            // 
            this.offerMeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.offerMeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.offerMeBtn.Location = new System.Drawing.Point(25, 472);
            this.offerMeBtn.Name = "offerMeBtn";
            this.offerMeBtn.Size = new System.Drawing.Size(188, 37);
            this.offerMeBtn.TabIndex = 14;
            this.offerMeBtn.Text = "הצעות למצלמות";
            this.offerMeBtn.UseVisualStyleBackColor = false;
            this.offerMeBtn.Click += new System.EventHandler(this.offerMeBtn_Click);
            // 
            // gotoeditprofitolobtn
            // 
            this.gotoeditprofitolobtn.Location = new System.Drawing.Point(25, 372);
            this.gotoeditprofitolobtn.Name = "gotoeditprofitolobtn";
            this.gotoeditprofitolobtn.Size = new System.Drawing.Size(188, 44);
            this.gotoeditprofitolobtn.TabIndex = 4;
            this.gotoeditprofitolobtn.Text = "עריכת תיק עבודות";
            this.gotoeditprofitolobtn.UseVisualStyleBackColor = true;
            this.gotoeditprofitolobtn.Click += new System.EventHandler(this.Gotoeditprofitolobtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(731, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "שלום";
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstnamelabel.Location = new System.Drawing.Point(567, 22);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(72, 20);
            this.firstnamelabel.TabIndex = 6;
            this.firstnamelabel.Text = "שם פרטי";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Lupa Traktor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(207, 87);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(22, 26);
            this.c.TabIndex = 12;
            this.c.Text = "?";
            // 
            // dontwanteventslabel
            // 
            this.dontwanteventslabel.AutoSize = true;
            this.dontwanteventslabel.Font = new System.Drawing.Font("Lupa Traktor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dontwanteventslabel.Location = new System.Drawing.Point(404, 87);
            this.dontwanteventslabel.Name = "dontwanteventslabel";
            this.dontwanteventslabel.Size = new System.Drawing.Size(27, 26);
            this.dontwanteventslabel.TabIndex = 11;
            this.dontwanteventslabel.Text = "X";
            // 
            // upcomingeventslabel
            // 
            this.upcomingeventslabel.AutoSize = true;
            this.upcomingeventslabel.Font = new System.Drawing.Font("Lupa Traktor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingeventslabel.Location = new System.Drawing.Point(622, 91);
            this.upcomingeventslabel.Name = "upcomingeventslabel";
            this.upcomingeventslabel.Size = new System.Drawing.Size(26, 26);
            this.upcomingeventslabel.TabIndex = 10;
            this.upcomingeventslabel.Text = "V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lupa Traktor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(98, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "אירועים שלא אישרתי עדיין";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lupa Traktor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(351, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "אירועים שסירבתי";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lupa Traktor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(535, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 26);
            this.label9.TabIndex = 7;
            this.label9.Text = "אירועים שאישרתי הגעה";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(441, 281);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(262, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "האירוע הקרוב הבא שלך בעוד";
            // 
            // daysLeftCloselabel
            // 
            this.daysLeftCloselabel.AutoSize = true;
            this.daysLeftCloselabel.Font = new System.Drawing.Font("Miriam Fixed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.daysLeftCloselabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.daysLeftCloselabel.Location = new System.Drawing.Point(369, 281);
            this.daysLeftCloselabel.Name = "daysLeftCloselabel";
            this.daysLeftCloselabel.Size = new System.Drawing.Size(66, 28);
            this.daysLeftCloselabel.TabIndex = 15;
            this.daysLeftCloselabel.Text = "000";
            // 
            // getdetbtn
            // 
            this.getdetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.getdetbtn.Location = new System.Drawing.Point(103, 275);
            this.getdetbtn.Name = "getdetbtn";
            this.getdetbtn.Size = new System.Drawing.Size(109, 72);
            this.getdetbtn.TabIndex = 16;
            this.getdetbtn.Text = "קבל פרטים";
            this.getdetbtn.UseVisualStyleBackColor = true;
            this.getdetbtn.Click += new System.EventHandler(this.Getdetbtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(640, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // noeventsPanel
            // 
            this.noeventsPanel.Controls.Add(this.label3);
            this.noeventsPanel.Location = new System.Drawing.Point(70, 256);
            this.noeventsPanel.Name = "noeventsPanel";
            this.noeventsPanel.Size = new System.Drawing.Size(660, 92);
            this.noeventsPanel.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(189, 30);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(247, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "אין בינתיים אירועים חדשים.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lupa Traktor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(622, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lupa Traktor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(405, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lupa Traktor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(207, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "?";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Miriam Fixed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.datelabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.datelabel.Location = new System.Drawing.Point(254, 320);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(192, 28);
            this.datelabel.TabIndex = 22;
            this.datelabel.Text = "00/00/0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(441, 320);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(262, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "כלומר, עתיד להתקיים בתאריך";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(326, 281);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(48, 24);
            this.label13.TabIndex = 24;
            this.label13.Text = "ימים";
            // 
            // goToUploadFormBtn
            // 
            this.goToUploadFormBtn.BackColor = System.Drawing.Color.Olive;
            this.goToUploadFormBtn.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToUploadFormBtn.Location = new System.Drawing.Point(140, 401);
            this.goToUploadFormBtn.Name = "goToUploadFormBtn";
            this.goToUploadFormBtn.Size = new System.Drawing.Size(517, 65);
            this.goToUploadFormBtn.TabIndex = 14;
            this.goToUploadFormBtn.Text = "כנס לאיזור העלאת התמונות";
            this.goToUploadFormBtn.UseVisualStyleBackColor = false;
            this.goToUploadFormBtn.Click += new System.EventHandler(this.GoToUploadFormBtn_Click);
            // 
            // profilepbx
            // 
            this.profilepbx.Image = global::HideItWF.Properties.Resources.gender_male2_512;
            this.profilepbx.Location = new System.Drawing.Point(34, 40);
            this.profilepbx.Name = "profilepbx";
            this.profilepbx.Size = new System.Drawing.Size(167, 142);
            this.profilepbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilepbx.TabIndex = 13;
            this.profilepbx.TabStop = false;
            this.profilepbx.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 524);
            this.Controls.Add(this.goToUploadFormBtn);
            this.Controls.Add(this.noeventsPanel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.getdetbtn);
            this.Controls.Add(this.daysLeftCloselabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.c);
            this.Controls.Add(this.dontwanteventslabel);
            this.Controls.Add(this.upcomingeventslabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.firstnamelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.noeventsPanel.ResumeLayout(false);
            this.noeventsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToUpcoming;
        private System.Windows.Forms.Button goToWaiting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button gotoeditprofitolobtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label dontwanteventslabel;
        private System.Windows.Forms.Label upcomingeventslabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox profilepbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label daysLeftCloselabel;
        private System.Windows.Forms.Button getdetbtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel noeventsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button goToUploadFormBtn;
        private System.Windows.Forms.Button offerMeBtn;
    }
}