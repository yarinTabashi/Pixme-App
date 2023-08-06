namespace HideItWF
{
    partial class EditProfitoloForm
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
            this.mainpbx = new System.Windows.Forms.PictureBox();
            this.nextimagebtn = new System.Windows.Forms.Button();
            this.lastimagebtn = new System.Windows.Forms.Button();
            this.gohomebtn = new System.Windows.Forms.Button();
            this.gotoallmypicturesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainpbx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(379, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ניהול תיק העבודות";
            // 
            // mainpbx
            // 
            this.mainpbx.Location = new System.Drawing.Point(212, 85);
            this.mainpbx.Name = "mainpbx";
            this.mainpbx.Size = new System.Drawing.Size(603, 368);
            this.mainpbx.TabIndex = 2;
            this.mainpbx.TabStop = false;
            // 
            // nextimagebtn
            // 
            this.nextimagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nextimagebtn.Location = new System.Drawing.Point(860, 242);
            this.nextimagebtn.Name = "nextimagebtn";
            this.nextimagebtn.Size = new System.Drawing.Size(63, 57);
            this.nextimagebtn.TabIndex = 3;
            this.nextimagebtn.Text = ">";
            this.nextimagebtn.UseVisualStyleBackColor = true;
            this.nextimagebtn.Click += new System.EventHandler(this.Nextimagebtn_Click);
            // 
            // lastimagebtn
            // 
            this.lastimagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastimagebtn.Location = new System.Drawing.Point(94, 242);
            this.lastimagebtn.Name = "lastimagebtn";
            this.lastimagebtn.Size = new System.Drawing.Size(63, 57);
            this.lastimagebtn.TabIndex = 4;
            this.lastimagebtn.Text = "<";
            this.lastimagebtn.UseVisualStyleBackColor = true;
            // 
            // gohomebtn
            // 
            this.gohomebtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.gohomebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gohomebtn.ForeColor = System.Drawing.Color.Red;
            this.gohomebtn.Location = new System.Drawing.Point(2, 0);
            this.gohomebtn.Name = "gohomebtn";
            this.gohomebtn.Size = new System.Drawing.Size(98, 42);
            this.gohomebtn.TabIndex = 5;
            this.gohomebtn.Text = "HOME";
            this.gohomebtn.UseVisualStyleBackColor = false;
            this.gohomebtn.Click += new System.EventHandler(this.Gohomebtn_Click);
            // 
            // gotoallmypicturesBtn
            // 
            this.gotoallmypicturesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gotoallmypicturesBtn.Location = new System.Drawing.Point(345, 483);
            this.gotoallmypicturesBtn.Name = "gotoallmypicturesBtn";
            this.gotoallmypicturesBtn.Size = new System.Drawing.Size(355, 61);
            this.gotoallmypicturesBtn.TabIndex = 6;
            this.gotoallmypicturesBtn.Text = "בחירה מתוך התמונות שצילמתי באירועים";
            this.gotoallmypicturesBtn.UseVisualStyleBackColor = true;
            this.gotoallmypicturesBtn.Click += new System.EventHandler(this.GotoallmypicturesBtn_Click);
            // 
            // EditProfitoloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 569);
            this.Controls.Add(this.gotoallmypicturesBtn);
            this.Controls.Add(this.gohomebtn);
            this.Controls.Add(this.lastimagebtn);
            this.Controls.Add(this.nextimagebtn);
            this.Controls.Add(this.mainpbx);
            this.Controls.Add(this.label1);
            this.Name = "EditProfitoloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfitoloForm";
            this.Load += new System.EventHandler(this.EditProfitoloForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainpbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mainpbx;
        private System.Windows.Forms.Button nextimagebtn;
        private System.Windows.Forms.Button lastimagebtn;
        private System.Windows.Forms.Button gohomebtn;
        private System.Windows.Forms.Button gotoallmypicturesBtn;
    }
}