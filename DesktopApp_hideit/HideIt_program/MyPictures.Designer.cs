namespace HideItWF
{
    partial class MyPictures
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
            this.gohomebtn = new System.Windows.Forms.Button();
            this.lastimagebtn = new System.Windows.Forms.Button();
            this.nextimagebtn = new System.Windows.Forms.Button();
            this.mainpbx = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addtomyprofitolo = new System.Windows.Forms.Button();
            this.goToEditProfitoloForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainpbx)).BeginInit();
            this.SuspendLayout();
            // 
            // gohomebtn
            // 
            this.gohomebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gohomebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gohomebtn.ForeColor = System.Drawing.Color.Red;
            this.gohomebtn.Location = new System.Drawing.Point(13, 12);
            this.gohomebtn.Name = "gohomebtn";
            this.gohomebtn.Size = new System.Drawing.Size(98, 42);
            this.gohomebtn.TabIndex = 10;
            this.gohomebtn.Text = "HOME";
            this.gohomebtn.UseVisualStyleBackColor = false;
            this.gohomebtn.Click += new System.EventHandler(this.gohomebtn_Click);
            // 
            // lastimagebtn
            // 
            this.lastimagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastimagebtn.Location = new System.Drawing.Point(105, 254);
            this.lastimagebtn.Name = "lastimagebtn";
            this.lastimagebtn.Size = new System.Drawing.Size(63, 57);
            this.lastimagebtn.TabIndex = 9;
            this.lastimagebtn.Text = "<";
            this.lastimagebtn.UseVisualStyleBackColor = true;
            this.lastimagebtn.Click += new System.EventHandler(this.Lastimagebtn_Click);
            // 
            // nextimagebtn
            // 
            this.nextimagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nextimagebtn.Location = new System.Drawing.Point(871, 254);
            this.nextimagebtn.Name = "nextimagebtn";
            this.nextimagebtn.Size = new System.Drawing.Size(63, 57);
            this.nextimagebtn.TabIndex = 8;
            this.nextimagebtn.Text = ">";
            this.nextimagebtn.UseVisualStyleBackColor = true;
            this.nextimagebtn.Click += new System.EventHandler(this.Nextimagebtn_Click);
            // 
            // mainpbx
            // 
            this.mainpbx.Location = new System.Drawing.Point(223, 97);
            this.mainpbx.Name = "mainpbx";
            this.mainpbx.Size = new System.Drawing.Size(603, 368);
            this.mainpbx.TabIndex = 7;
            this.mainpbx.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(390, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "ניהול תיק העבודות";
            // 
            // addtomyprofitolo
            // 
            this.addtomyprofitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addtomyprofitolo.Location = new System.Drawing.Point(338, 500);
            this.addtomyprofitolo.Name = "addtomyprofitolo";
            this.addtomyprofitolo.Size = new System.Drawing.Size(354, 61);
            this.addtomyprofitolo.TabIndex = 11;
            this.addtomyprofitolo.Text = "שים את התמונה הזו בתיק עבודות שלי";
            this.addtomyprofitolo.UseVisualStyleBackColor = true;
            this.addtomyprofitolo.Click += new System.EventHandler(this.Addtomyprofitolo_Click);
            // 
            // goToEditProfitoloForm
            // 
            this.goToEditProfitoloForm.BackColor = System.Drawing.SystemColors.MenuText;
            this.goToEditProfitoloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.goToEditProfitoloForm.ForeColor = System.Drawing.Color.Red;
            this.goToEditProfitoloForm.Location = new System.Drawing.Point(117, 12);
            this.goToEditProfitoloForm.Name = "goToEditProfitoloForm";
            this.goToEditProfitoloForm.Size = new System.Drawing.Size(98, 42);
            this.goToEditProfitoloForm.TabIndex = 12;
            this.goToEditProfitoloForm.Text = "BACK";
            this.goToEditProfitoloForm.UseVisualStyleBackColor = false;
            this.goToEditProfitoloForm.Click += new System.EventHandler(this.GoToEditProfitoloForm_Click);
            // 
            // MyPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 596);
            this.Controls.Add(this.goToEditProfitoloForm);
            this.Controls.Add(this.addtomyprofitolo);
            this.Controls.Add(this.gohomebtn);
            this.Controls.Add(this.lastimagebtn);
            this.Controls.Add(this.nextimagebtn);
            this.Controls.Add(this.mainpbx);
            this.Controls.Add(this.label1);
            this.Name = "MyPictures";
            this.Text = "MyPictures";
            this.Load += new System.EventHandler(this.MyPictures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainpbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gohomebtn;
        private System.Windows.Forms.Button lastimagebtn;
        private System.Windows.Forms.Button nextimagebtn;
        private System.Windows.Forms.PictureBox mainpbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addtomyprofitolo;
        private System.Windows.Forms.Button goToEditProfitoloForm;
    }
}