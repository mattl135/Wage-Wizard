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
            SuspendLayout();
            // 
            // userIDTextField
            // 
            userIDTextField.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            userIDTextField.Location = new Point(159, 296);
            userIDTextField.Margin = new Padding(3, 4, 3, 4);
            userIDTextField.MaxLength = 8;
            userIDTextField.Name = "userIDTextField";
            userIDTextField.PlaceholderText = "User ID";
            userIDTextField.Size = new Size(209, 32);
            userIDTextField.TabIndex = 0;
            userIDTextField.TextChanged += userIDTextField_TextChanged;
            userIDTextField.KeyDown += LoginForm_KeyDown;
            // 
            // passwordTextField
            // 
            passwordTextField.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextField.Location = new Point(159, 360);
            passwordTextField.Margin = new Padding(3, 4, 3, 4);
            passwordTextField.MaxLength = 32;
            passwordTextField.Name = "passwordTextField";
            passwordTextField.PasswordChar = '*';
            passwordTextField.PlaceholderText = "Password";
            passwordTextField.Size = new Size(209, 32);
            passwordTextField.TabIndex = 1;
            passwordTextField.UseSystemPasswordChar = true;
            passwordTextField.KeyDown += LoginForm_KeyDown;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(199, 456);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(127, 61);
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
            label1.Location = new Point(133, 135);
            label1.Name = "label1";
            label1.Size = new Size(282, 60);
            label1.TabIndex = 3;
            label1.Text = "Wage Wizard";
            // 
            // loginDescription
            // 
            loginDescription.AutoSize = true;
            loginDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loginDescription.Location = new Point(74, 228);
            loginDescription.Name = "loginDescription";
            loginDescription.Size = new Size(450, 25);
            loginDescription.TabIndex = 4;
            loginDescription.Text = "Please enter your User ID and Password to continue.";
            loginDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 600);
            Controls.Add(loginDescription);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextField);
            Controls.Add(userIDTextField);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Padding = new Padding(29, 33, 29, 33);
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
    }
}