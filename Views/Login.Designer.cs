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
            userIDTextField = new TextBox();
            passwordTextField = new TextBox();
            loginBtn = new Button();
            label1 = new Label();
            loginDescription = new Label();
            exitApplication = new Button();
            SuspendLayout();
            // 
            // userIDTextField
            // 
            userIDTextField.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            userIDTextField.Location = new Point(139, 179);
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
            passwordTextField.Location = new Point(139, 227);
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
            loginBtn.Location = new Point(174, 299);
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
            label1.Location = new Point(116, 58);
            label1.Name = "label1";
            label1.Size = new Size(227, 47);
            label1.TabIndex = 3;
            label1.Text = "Wage Wizard";
            // 
            // loginDescription
            // 
            loginDescription.AutoSize = true;
            loginDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loginDescription.Location = new Point(65, 128);
            loginDescription.Name = "loginDescription";
            loginDescription.Size = new Size(350, 20);
            loginDescription.TabIndex = 4;
            loginDescription.Text = "Please enter your User ID and Password to continue.";
            loginDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitApplication
            // 
            exitApplication.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitApplication.Location = new Point(174, 362);
            exitApplication.Name = "exitApplication";
            exitApplication.Size = new Size(111, 46);
            exitApplication.TabIndex = 5;
            exitApplication.Text = "Exit";
            exitApplication.UseVisualStyleBackColor = true;
            exitApplication.Click += exitApplication_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(exitApplication);
            Controls.Add(loginDescription);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextField);
            Controls.Add(userIDTextField);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            Padding = new Padding(25);
            Text = "Wage Wizard - Login";
            Click += LoginForm_Click;
            KeyDown += LoginForm_KeyDown;
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
    }
}