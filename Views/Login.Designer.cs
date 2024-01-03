namespace Wage_Wizard
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            userIDTextField = new TextBox();
            passwordTextField = new TextBox();
            loginBtn = new Button();
            label1 = new Label();
            loginDescription = new Label();
            exitApplication = new Button();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // userIDTextField
            // 
            userIDTextField.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            userIDTextField.Location = new Point(135, 348);
            userIDTextField.MaxLength = 8;
            userIDTextField.Name = "userIDTextField";
            userIDTextField.PlaceholderText = "User ID";
            userIDTextField.Size = new Size(183, 27);
            userIDTextField.TabIndex = 0;
            userIDTextField.KeyDown += LoginForm_KeyDown;
            // 
            // passwordTextField
            // 
            passwordTextField.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextField.Location = new Point(135, 396);
            passwordTextField.MaxLength = 32;
            passwordTextField.Name = "passwordTextField";
            passwordTextField.PasswordChar = '*';
            passwordTextField.PlaceholderText = "Password";
            passwordTextField.Size = new Size(183, 27);
            passwordTextField.TabIndex = 1;
            passwordTextField.UseSystemPasswordChar = true;
            passwordTextField.KeyDown += LoginForm_KeyDown;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(170, 468);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(111, 46);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            loginBtn.KeyDown += LoginForm_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(112, 227);
            label1.Name = "label1";
            label1.Size = new Size(227, 47);
            label1.TabIndex = 3;
            label1.Text = "Wage Wizard";
            // 
            // loginDescription
            // 
            loginDescription.AutoSize = true;
            loginDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loginDescription.Location = new Point(61, 297);
            loginDescription.Name = "loginDescription";
            loginDescription.Size = new Size(350, 20);
            loginDescription.TabIndex = 4;
            loginDescription.Text = "Please enter your User ID and Password to continue.";
            loginDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitApplication
            // 
            exitApplication.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitApplication.Location = new Point(170, 531);
            exitApplication.Name = "exitApplication";
            exitApplication.Size = new Size(111, 46);
            exitApplication.TabIndex = 5;
            exitApplication.Text = "Exit";
            exitApplication.UseVisualStyleBackColor = true;
            exitApplication.Click += exitApplication_Click;
            // 
            // logo
            // 
            logo.ImageLocation = "";
            logo.Location = new Point(86, 17);
            logo.Name = "logo";
            logo.Size = new Size(291, 207);
            logo.TabIndex = 6;
            logo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(473, 600);
            Controls.Add(logo);
            Controls.Add(exitApplication);
            Controls.Add(loginDescription);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextField);
            Controls.Add(userIDTextField);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            Padding = new Padding(25);
            Text = "Wage Wizard - Login";
            FormClosing += formClosing;
            Click += LoginForm_Click;
            KeyDown += LoginForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userIDTextField;
        private TextBox passwordTextField;
        private Button loginBtn;
        private Label label1;
        private Label loginDescription;
        private Button exitApplication;
        private PictureBox logo;
    }
}