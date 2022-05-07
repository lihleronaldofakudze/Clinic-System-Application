
namespace Clinic_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoginTopic = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.bRegisterNewAccount = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginTopic
            // 
            this.lblLoginTopic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoginTopic.AutoSize = true;
            this.lblLoginTopic.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginTopic.ForeColor = System.Drawing.Color.White;
            this.lblLoginTopic.Location = new System.Drawing.Point(92, 8);
            this.lblLoginTopic.Name = "lblLoginTopic";
            this.lblLoginTopic.Size = new System.Drawing.Size(341, 90);
            this.lblLoginTopic.TabIndex = 0;
            this.lblLoginTopic.Text = "Welcome Back \r\neZulwini Clinic System";
            this.lblLoginTopic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLoginTopic.Click += new System.EventHandler(this.lblLoginTopic_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.bRegisterNewAccount);
            this.gbLogin.Controls.Add(this.bLogin);
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.tbUsername);
            this.gbLogin.Location = new System.Drawing.Point(12, 155);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(507, 283);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Please enter all required details";
            // 
            // bRegisterNewAccount
            // 
            this.bRegisterNewAccount.Location = new System.Drawing.Point(319, 254);
            this.bRegisterNewAccount.Name = "bRegisterNewAccount";
            this.bRegisterNewAccount.Size = new System.Drawing.Size(182, 23);
            this.bRegisterNewAccount.TabIndex = 3;
            this.bRegisterNewAccount.Text = "Register New Account";
            this.bRegisterNewAccount.UseVisualStyleBackColor = true;
            this.bRegisterNewAccount.Click += new System.EventHandler(this.bRegisterNewAccount_Click);
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(207, 159);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 2;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(127, 115);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(238, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(127, 70);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(238, 23);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblLoginTopic);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 100);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoginTopic;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bRegisterNewAccount;
    }
}

