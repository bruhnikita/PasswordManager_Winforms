namespace PasswordManager_Winforms
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
            generateButton = new Button();
            resultTextBox = new TextBox();
            encryptedPasswordTextBox = new TextBox();
            encryptButton = new Button();
            SuspendLayout();
            // 
            // generateButton
            // 
            generateButton.Dock = DockStyle.Bottom;
            generateButton.Location = new Point(0, 357);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(372, 47);
            generateButton.TabIndex = 0;
            generateButton.Text = "Сгенерировать пароль";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Dock = DockStyle.Top;
            resultTextBox.Location = new Point(0, 0);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.PlaceholderText = "Здесь будет ваш пароль...";
            resultTextBox.Size = new Size(372, 50);
            resultTextBox.TabIndex = 3;
            // 
            // encryptedPasswordTextBox
            // 
            encryptedPasswordTextBox.Dock = DockStyle.Top;
            encryptedPasswordTextBox.Location = new Point(0, 50);
            encryptedPasswordTextBox.Multiline = true;
            encryptedPasswordTextBox.Name = "encryptedPasswordTextBox";
            encryptedPasswordTextBox.PlaceholderText = "Зашифрованный пароль";
            encryptedPasswordTextBox.Size = new Size(372, 50);
            encryptedPasswordTextBox.TabIndex = 4;
            // 
            // encryptButton
            // 
            encryptButton.Dock = DockStyle.Bottom;
            encryptButton.Location = new Point(0, 310);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(372, 47);
            encryptButton.TabIndex = 1;
            encryptButton.Text = "Зашифровать пароль";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += encryptButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 404);
            Controls.Add(encryptedPasswordTextBox);
            Controls.Add(resultTextBox);
            Controls.Add(encryptButton);
            Controls.Add(generateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generateButton;
        private TextBox resultTextBox;
        private TextBox encryptedPasswordTextBox;
        private TextBox decryptedPasswordTextBox;
        private Button encryptButton;
    }
}
