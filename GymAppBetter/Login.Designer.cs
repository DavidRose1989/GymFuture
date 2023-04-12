namespace GymAppBetter
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtBoxPassword = new TextBox();
            txtBoxUserName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBoxPassword);
            panel1.Controls.Add(txtBoxUserName);
            panel1.Location = new Point(550, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 593);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlDarkDark;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(200, 411);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(371, 78);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(188, 259);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 107);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.BackColor = SystemColors.ButtonShadow;
            txtBoxPassword.Location = new Point(188, 306);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(404, 31);
            txtBoxPassword.TabIndex = 1;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.BackColor = SystemColors.ControlDark;
            txtBoxUserName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxUserName.Location = new Point(188, 147);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(404, 34);
            txtBoxUserName.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1231, 919);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUserName;
    }
}