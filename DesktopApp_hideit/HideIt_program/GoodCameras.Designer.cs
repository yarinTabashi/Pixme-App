namespace HideItWF
{
    partial class GoodCameras
    {
        private System.ComponentModel.IContainer components = null;

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
            this.label2 = new System.Windows.Forms.Label();
            this.gohomebtn = new System.Windows.Forms.Button();
            this.camerasListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(197, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "הצעת מצלמות איכותיות ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(726, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "צלם יקר, אנחנו יודעים שאיכות המצלמה חשובה לך.\r\nולכן, החלטנו להציע לך פלאפונים עם " +
    "מצלמות איכותיות אותן תוכל לרכוש..";
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
            this.gohomebtn.Click += new System.EventHandler(this.gohomebtn_Click);
            // 
            // camerasListBox
            // 
            this.camerasListBox.BackColor = System.Drawing.Color.Orange;
            this.camerasListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.camerasListBox.FormattingEnabled = true;
            this.camerasListBox.ItemHeight = 24;
            this.camerasListBox.Location = new System.Drawing.Point(193, 180);
            this.camerasListBox.Name = "camerasListBox";
            this.camerasListBox.Size = new System.Drawing.Size(357, 388);
            this.camerasListBox.TabIndex = 7;
            // 
            // GoodCameras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 603);
            this.Controls.Add(this.camerasListBox);
            this.Controls.Add(this.gohomebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GoodCameras";
            this.Text = "GoodCameras";
            this.Load += new System.EventHandler(this.GoodCameras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gohomebtn;
        private System.Windows.Forms.ListBox camerasListBox;
    }
}