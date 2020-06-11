namespace dadosGame
{
    partial class RegisterForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.gpbRegisterForm = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.NumericUpDown();
            this.rdbPlayer1 = new System.Windows.Forms.RadioButton();
            this.rdbPlayer2 = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gpbRegisterForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nickname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(92, 45);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(218, 20);
            this.txtNickname.TabIndex = 4;
            // 
            // gpbRegisterForm
            // 
            this.gpbRegisterForm.Controls.Add(this.txtAge);
            this.gpbRegisterForm.Controls.Add(this.label2);
            this.gpbRegisterForm.Controls.Add(this.txtName);
            this.gpbRegisterForm.Controls.Add(this.txtNickname);
            this.gpbRegisterForm.Controls.Add(this.label3);
            this.gpbRegisterForm.Controls.Add(this.label1);
            this.gpbRegisterForm.Location = new System.Drawing.Point(12, 48);
            this.gpbRegisterForm.Name = "gpbRegisterForm";
            this.gpbRegisterForm.Size = new System.Drawing.Size(316, 122);
            this.gpbRegisterForm.TabIndex = 5;
            this.gpbRegisterForm.TabStop = false;
            this.gpbRegisterForm.Text = "Register Form";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(92, 71);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(218, 20);
            this.txtAge.TabIndex = 6;
            // 
            // rdbPlayer1
            // 
            this.rdbPlayer1.AutoSize = true;
            this.rdbPlayer1.Checked = true;
            this.rdbPlayer1.Location = new System.Drawing.Point(13, 4);
            this.rdbPlayer1.Name = "rdbPlayer1";
            this.rdbPlayer1.Size = new System.Drawing.Size(63, 17);
            this.rdbPlayer1.TabIndex = 6;
            this.rdbPlayer1.TabStop = true;
            this.rdbPlayer1.Text = "Player 1";
            this.rdbPlayer1.UseVisualStyleBackColor = true;
            this.rdbPlayer1.CheckedChanged += new System.EventHandler(this.rdbPlayer1_CheckedChanged);
            // 
            // rdbPlayer2
            // 
            this.rdbPlayer2.AutoSize = true;
            this.rdbPlayer2.Location = new System.Drawing.Point(104, 4);
            this.rdbPlayer2.Name = "rdbPlayer2";
            this.rdbPlayer2.Size = new System.Drawing.Size(63, 17);
            this.rdbPlayer2.TabIndex = 7;
            this.rdbPlayer2.Text = "Player 2";
            this.rdbPlayer2.UseVisualStyleBackColor = true;
            this.rdbPlayer2.CheckedChanged += new System.EventHandler(this.rdbPlayer2_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(132, 176);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(95, 30);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(227, 176);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 30);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(340, 218);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rdbPlayer2);
            this.Controls.Add(this.rdbPlayer1);
            this.Controls.Add(this.gpbRegisterForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "Register Form";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.gpbRegisterForm.ResumeLayout(false);
            this.gpbRegisterForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbRegisterForm;
        private System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtNickname;
        public System.Windows.Forms.RadioButton rdbPlayer1;
        public System.Windows.Forms.RadioButton rdbPlayer2;
        private System.Windows.Forms.NumericUpDown txtAge;
        private System.Windows.Forms.Button btnStart;
    }
}