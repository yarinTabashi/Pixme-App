namespace HideItWF
{
    partial class AddImagesForEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.eventsNamesCbx = new System.Windows.Forms.ComboBox();
            this.uploadImagesBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.counterUploadsLbl = new System.Windows.Forms.Label();
            this.gohomebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(139, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "בחר אירוע שברצנוך להעלות תמונות אליו";
            // 
            // eventsNamesCbx
            // 
            this.eventsNamesCbx.BackColor = System.Drawing.Color.White;
            this.eventsNamesCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventsNamesCbx.FormattingEnabled = true;
            this.eventsNamesCbx.Location = new System.Drawing.Point(160, 106);
            this.eventsNamesCbx.Name = "eventsNamesCbx";
            this.eventsNamesCbx.Size = new System.Drawing.Size(312, 32);
            this.eventsNamesCbx.TabIndex = 1;
            this.eventsNamesCbx.SelectedIndexChanged += new System.EventHandler(this.EventsNamesCbx_SelectedIndexChanged);
            // 
            // uploadImagesBtn
            // 
            this.uploadImagesBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.uploadImagesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.uploadImagesBtn.Location = new System.Drawing.Point(96, 204);
            this.uploadImagesBtn.Name = "uploadImagesBtn";
            this.uploadImagesBtn.Size = new System.Drawing.Size(447, 87);
            this.uploadImagesBtn.TabIndex = 2;
            this.uploadImagesBtn.Text = "בחר";
            this.uploadImagesBtn.UseVisualStyleBackColor = false;
            this.uploadImagesBtn.Click += new System.EventHandler(this.UploadImagesBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(222, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "תמונות שנוספו";
            // 
            // counterUploadsLbl
            // 
            this.counterUploadsLbl.AutoSize = true;
            this.counterUploadsLbl.BackColor = System.Drawing.Color.Transparent;
            this.counterUploadsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.counterUploadsLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.counterUploadsLbl.Location = new System.Drawing.Point(351, 294);
            this.counterUploadsLbl.Name = "counterUploadsLbl";
            this.counterUploadsLbl.Size = new System.Drawing.Size(32, 24);
            this.counterUploadsLbl.TabIndex = 4;
            this.counterUploadsLbl.Text = "??";
            // 
            // gohomebtn
            // 
            this.gohomebtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.gohomebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gohomebtn.ForeColor = System.Drawing.Color.Red;
            this.gohomebtn.Location = new System.Drawing.Point(12, 12);
            this.gohomebtn.Name = "gohomebtn";
            this.gohomebtn.Size = new System.Drawing.Size(98, 42);
            this.gohomebtn.TabIndex = 6;
            this.gohomebtn.Text = "HOME";
            this.gohomebtn.UseVisualStyleBackColor = false;
            this.gohomebtn.Click += new System.EventHandler(this.Gohomebtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "בחרתי";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddImagesForEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gohomebtn);
            this.Controls.Add(this.counterUploadsLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uploadImagesBtn);
            this.Controls.Add(this.eventsNamesCbx);
            this.Controls.Add(this.label1);
            this.Name = "AddImagesForEvent";
            this.Text = "AddImagesForEvent";
            this.Load += new System.EventHandler(this.AddImagesForEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eventsNamesCbx;
        private System.Windows.Forms.Button uploadImagesBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label counterUploadsLbl;
        private System.Windows.Forms.Button gohomebtn;
        private System.Windows.Forms.Button button1;
    }
}