namespace HideItWF
{
    partial class GetDetailsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.noagreebtn = new System.Windows.Forms.Button();
            this.needToacceptPanel = new System.Windows.Forms.Panel();
            this.agreebtn = new System.Windows.Forms.Button();
            this.eventnamelabel = new System.Windows.Forms.Label();
            this.eventdisclabel = new System.Windows.Forms.Label();
            this.eventdatelabel = new System.Windows.Forms.Label();
            this.eventlocaitionlabel = new System.Windows.Forms.Label();
            this.alreadyacceptedPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.needToacceptPanel.SuspendLayout();
            this.alreadyacceptedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(206, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "פרטי האירוע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(453, 60);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "שם האירוע:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(487, 104);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "תיאור:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(479, 150);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "תאריך:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(485, 202);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "מיקום:";
            // 
            // noagreebtn
            // 
            this.noagreebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.noagreebtn.Location = new System.Drawing.Point(40, 10);
            this.noagreebtn.Name = "noagreebtn";
            this.noagreebtn.Size = new System.Drawing.Size(96, 28);
            this.noagreebtn.TabIndex = 6;
            this.noagreebtn.Text = "לא מעוניין";
            this.noagreebtn.UseVisualStyleBackColor = true;
            // 
            // needToacceptPanel
            // 
            this.needToacceptPanel.Controls.Add(this.agreebtn);
            this.needToacceptPanel.Controls.Add(this.noagreebtn);
            this.needToacceptPanel.Location = new System.Drawing.Point(114, 260);
            this.needToacceptPanel.Name = "needToacceptPanel";
            this.needToacceptPanel.Size = new System.Drawing.Size(309, 41);
            this.needToacceptPanel.TabIndex = 8;
            this.needToacceptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // agreebtn
            // 
            this.agreebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.agreebtn.Location = new System.Drawing.Point(181, 10);
            this.agreebtn.Name = "agreebtn";
            this.agreebtn.Size = new System.Drawing.Size(96, 28);
            this.agreebtn.TabIndex = 7;
            this.agreebtn.Text = "מאשר";
            this.agreebtn.UseVisualStyleBackColor = true;
            // 
            // eventnamelabel
            // 
            this.eventnamelabel.AutoSize = true;
            this.eventnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventnamelabel.Location = new System.Drawing.Point(239, 60);
            this.eventnamelabel.Name = "eventnamelabel";
            this.eventnamelabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eventnamelabel.Size = new System.Drawing.Size(14, 20);
            this.eventnamelabel.TabIndex = 9;
            this.eventnamelabel.Text = "-";
            // 
            // eventdisclabel
            // 
            this.eventdisclabel.AutoSize = true;
            this.eventdisclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventdisclabel.Location = new System.Drawing.Point(202, 104);
            this.eventdisclabel.Name = "eventdisclabel";
            this.eventdisclabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eventdisclabel.Size = new System.Drawing.Size(14, 20);
            this.eventdisclabel.TabIndex = 10;
            this.eventdisclabel.Text = "-";
            // 
            // eventdatelabel
            // 
            this.eventdatelabel.AutoSize = true;
            this.eventdatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventdatelabel.Location = new System.Drawing.Point(239, 150);
            this.eventdatelabel.Name = "eventdatelabel";
            this.eventdatelabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eventdatelabel.Size = new System.Drawing.Size(14, 20);
            this.eventdatelabel.TabIndex = 11;
            this.eventdatelabel.Text = "-";
            // 
            // eventlocaitionlabel
            // 
            this.eventlocaitionlabel.AutoSize = true;
            this.eventlocaitionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventlocaitionlabel.Location = new System.Drawing.Point(240, 202);
            this.eventlocaitionlabel.Name = "eventlocaitionlabel";
            this.eventlocaitionlabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eventlocaitionlabel.Size = new System.Drawing.Size(14, 20);
            this.eventlocaitionlabel.TabIndex = 12;
            this.eventlocaitionlabel.Text = "-";
            // 
            // alreadyacceptedPanel
            // 
            this.alreadyacceptedPanel.Controls.Add(this.label6);
            this.alreadyacceptedPanel.Location = new System.Drawing.Point(117, 238);
            this.alreadyacceptedPanel.Name = "alreadyacceptedPanel";
            this.alreadyacceptedPanel.Size = new System.Drawing.Size(309, 68);
            this.alreadyacceptedPanel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(41, 21);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(226, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "אישרת כבר הגעה!";
            // 
            // GetDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 313);
            this.Controls.Add(this.alreadyacceptedPanel);
            this.Controls.Add(this.eventlocaitionlabel);
            this.Controls.Add(this.eventdatelabel);
            this.Controls.Add(this.eventdisclabel);
            this.Controls.Add(this.eventnamelabel);
            this.Controls.Add(this.needToacceptPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GetDetailsForm";
            this.Text = "GetDetailsForm";
            this.Load += new System.EventHandler(this.GetDetailsForm_Load);
            this.needToacceptPanel.ResumeLayout(false);
            this.alreadyacceptedPanel.ResumeLayout(false);
            this.alreadyacceptedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button noagreebtn;
        private System.Windows.Forms.Panel needToacceptPanel;
        private System.Windows.Forms.Button agreebtn;
        private System.Windows.Forms.Label eventnamelabel;
        private System.Windows.Forms.Label eventdisclabel;
        private System.Windows.Forms.Label eventdatelabel;
        private System.Windows.Forms.Label eventlocaitionlabel;
        private System.Windows.Forms.Panel alreadyacceptedPanel;
        private System.Windows.Forms.Label label6;
    }
}