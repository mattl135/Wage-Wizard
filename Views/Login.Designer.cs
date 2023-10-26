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
            SuspendLayout();
            // 
            // userIDTextField
            // 
            userIDTextField.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            userIDTextField.Location = new Point(139, 169);
            userIDTextField.MaxLength = 8;
            userIDTextField.Name = "userIDTextField";
            userIDTextField.PlaceholderText = "Username";
            userIDTextField.Size = new Size(183, 27);
            userIDTextField.TabIndex = 0;
            userIDTextField.TextChanged += textBox1_TextChanged;
            // 
            // passwordTextField
            // 
            passwordTextField.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextField.Location = new Point(139, 217);
            passwordTextField.MaxLength = 8;
            passwordTextField.Name = "passwordTextField";
            passwordTextField.PasswordChar = '*';
            passwordTextField.PlaceholderText = "Password";
            passwordTextField.Size = new Size(183, 27);
            passwordTextField.TabIndex = 1;
            passwordTextField.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(169, 273);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(111, 46);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 101);
            label1.Name = "label1";
            label1.Size = new Size(227, 47);
            label1.TabIndex = 3;
            label1.Text = "Wage Wizard";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextField);
            Controls.Add(userIDTextField);
            Name = "Login";
            Padding = new Padding(25);
            Text = "Wage Wizard - Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userIDTextField;
        private TextBox passwordTextField;
        private Button loginBtn;
        private Label label1;
    }
}