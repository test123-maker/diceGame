namespace dadosGame
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.gpbPlayer1 = new System.Windows.Forms.GroupBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.ptbPlayer1 = new System.Windows.Forms.PictureBox();
            this.gpbPlayer2 = new System.Windows.Forms.GroupBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.ptbPlayer2 = new System.Windows.Forms.PictureBox();
            this.lbl_Vencedor = new System.Windows.Forms.Label();
            this.btnRegiter = new System.Windows.Forms.Button();
            this.gpbPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlayer1)).BeginInit();
            this.gpbPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.Location = new System.Drawing.Point(39, 260);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(111, 83);
            this.btnPlayer1.TabIndex = 0;
            this.btnPlayer1.Text = "Player1";
            this.btnPlayer1.UseVisualStyleBackColor = true;
            this.btnPlayer1.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(223, 373);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(195, 59);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.Location = new System.Drawing.Point(47, 260);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(111, 83);
            this.btnPlayer2.TabIndex = 3;
            this.btnPlayer2.Text = "Player2";
            this.btnPlayer2.UseVisualStyleBackColor = true;
            this.btnPlayer2.Click += new System.EventHandler(this.btnPlayer2_Click);
            // 
            // gpbPlayer1
            // 
            this.gpbPlayer1.Controls.Add(this.lbl_1);
            this.gpbPlayer1.Controls.Add(this.ptbPlayer1);
            this.gpbPlayer1.Controls.Add(this.btnPlayer1);
            this.gpbPlayer1.Location = new System.Drawing.Point(12, 12);
            this.gpbPlayer1.Name = "gpbPlayer1";
            this.gpbPlayer1.Size = new System.Drawing.Size(202, 356);
            this.gpbPlayer1.TabIndex = 4;
            this.gpbPlayer1.TabStop = false;
            this.gpbPlayer1.Text = "Player1";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(71, 132);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(36, 26);
            this.lbl_1.TabIndex = 8;
            this.lbl_1.Text = "10";
            // 
            // ptbPlayer1
            // 
            this.ptbPlayer1.Image = ((System.Drawing.Image)(resources.GetObject("ptbPlayer1.Image")));
            this.ptbPlayer1.Location = new System.Drawing.Point(57, 43);
            this.ptbPlayer1.Name = "ptbPlayer1";
            this.ptbPlayer1.Size = new System.Drawing.Size(82, 81);
            this.ptbPlayer1.TabIndex = 5;
            this.ptbPlayer1.TabStop = false;
            // 
            // gpbPlayer2
            // 
            this.gpbPlayer2.Controls.Add(this.lbl_2);
            this.gpbPlayer2.Controls.Add(this.ptbPlayer2);
            this.gpbPlayer2.Controls.Add(this.btnPlayer2);
            this.gpbPlayer2.Location = new System.Drawing.Point(434, 12);
            this.gpbPlayer2.Name = "gpbPlayer2";
            this.gpbPlayer2.Size = new System.Drawing.Size(202, 356);
            this.gpbPlayer2.TabIndex = 5;
            this.gpbPlayer2.TabStop = false;
            this.gpbPlayer2.Text = "Player2";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Old English Text MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_2.Location = new System.Drawing.Point(80, 132);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(36, 26);
            this.lbl_2.TabIndex = 9;
            this.lbl_2.Text = "10";
            // 
            // ptbPlayer2
            // 
            this.ptbPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("ptbPlayer2.Image")));
            this.ptbPlayer2.Location = new System.Drawing.Point(62, 43);
            this.ptbPlayer2.Name = "ptbPlayer2";
            this.ptbPlayer2.Size = new System.Drawing.Size(80, 77);
            this.ptbPlayer2.TabIndex = 4;
            this.ptbPlayer2.TabStop = false;
            // 
            // lbl_Vencedor
            // 
            this.lbl_Vencedor.AutoSize = true;
            this.lbl_Vencedor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vencedor.Location = new System.Drawing.Point(266, 23);
            this.lbl_Vencedor.Name = "lbl_Vencedor";
            this.lbl_Vencedor.Size = new System.Drawing.Size(95, 20);
            this.lbl_Vencedor.TabIndex = 6;
            this.lbl_Vencedor.Text = "The Winner is...";
            // 
            // btnRegiter
            // 
            this.btnRegiter.Location = new System.Drawing.Point(481, 391);
            this.btnRegiter.Name = "btnRegiter";
            this.btnRegiter.Size = new System.Drawing.Size(127, 23);
            this.btnRegiter.TabIndex = 7;
            this.btnRegiter.Text = "Register";
            this.btnRegiter.UseVisualStyleBackColor = true;
            this.btnRegiter.Click += new System.EventHandler(this.btnRegiter_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.btnRegiter);
            this.Controls.Add(this.lbl_Vencedor);
            this.Controls.Add(this.gpbPlayer2);
            this.Controls.Add(this.gpbPlayer1);
            this.Controls.Add(this.btnRestart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Game In the World";
            this.gpbPlayer1.ResumeLayout(false);
            this.gpbPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlayer1)).EndInit();
            this.gpbPlayer2.ResumeLayout(false);
            this.gpbPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.GroupBox gpbPlayer1;
        private System.Windows.Forms.PictureBox ptbPlayer1;
        private System.Windows.Forms.GroupBox gpbPlayer2;
        private System.Windows.Forms.PictureBox ptbPlayer2;
        private System.Windows.Forms.Label lbl_Vencedor;
        private System.Windows.Forms.Button btnRegiter;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
    }
}

