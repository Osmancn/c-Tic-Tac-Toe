namespace Tic_Tac_Toe
{
    partial class frmAnaMenu
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
            this.btnTek = new System.Windows.Forms.Button();
            this.btnCift = new System.Windows.Forms.Button();
            this.btnOnline = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // btnTek
            // 
            this.btnTek.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTek.Location = new System.Drawing.Point(136, 143);
            this.btnTek.Name = "btnTek";
            this.btnTek.Size = new System.Drawing.Size(225, 35);
            this.btnTek.TabIndex = 1;
            this.btnTek.Text = "Tek Oyunculu";
            this.btnTek.UseVisualStyleBackColor = true;
            this.btnTek.Click += new System.EventHandler(this.btnTek_Click);
            // 
            // btnCift
            // 
            this.btnCift.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCift.Location = new System.Drawing.Point(136, 195);
            this.btnCift.Name = "btnCift";
            this.btnCift.Size = new System.Drawing.Size(225, 35);
            this.btnCift.TabIndex = 2;
            this.btnCift.Text = "Çift Oyunculu";
            this.btnCift.UseVisualStyleBackColor = true;
            this.btnCift.Click += new System.EventHandler(this.btnCift_Click);
            // 
            // btnOnline
            // 
            this.btnOnline.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOnline.Location = new System.Drawing.Point(136, 250);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(225, 35);
            this.btnOnline.TabIndex = 3;
            this.btnOnline.Text = "Online Oyna";
            this.btnOnline.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCikis.Location = new System.Drawing.Point(136, 302);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(225, 35);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 454);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOnline);
            this.Controls.Add(this.btnCift);
            this.Controls.Add(this.btnTek);
            this.Controls.Add(this.label1);
            this.Name = "frmAnaMenu";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTek;
        private System.Windows.Forms.Button btnCift;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Button btnCikis;
    }
}