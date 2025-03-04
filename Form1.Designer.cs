namespace SimpleNativeLLMClient
{
    partial class SimpleNativeLLMClient
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
            label1 = new Label();
            urlTextBox = new TextBox();
            apiKeyTextBox = new TextBox();
            label2 = new Label();
            responseTextBox = new TextBox();
            label3 = new Label();
            promptTextBox = new TextBox();
            sendButton = new Button();
            clearButton = new Button();
            modelTextBox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Server URL";
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(86, 11);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(353, 23);
            urlTextBox.TabIndex = 1;
            urlTextBox.Text = "https://api.openai.com";
            // 
            // apiKeyTextBox
            // 
            apiKeyTextBox.Location = new Point(86, 40);
            apiKeyTextBox.Name = "apiKeyTextBox";
            apiKeyTextBox.PasswordChar = '*';
            apiKeyTextBox.Size = new Size(353, 23);
            apiKeyTextBox.TabIndex = 3;
            apiKeyTextBox.Text = "https://api.openai.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 43);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "API Key";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // responseTextBox
            // 
            responseTextBox.Location = new Point(17, 120);
            responseTextBox.Multiline = true;
            responseTextBox.Name = "responseTextBox";
            responseTextBox.ReadOnly = true;
            responseTextBox.ScrollBars = ScrollBars.Both;
            responseTextBox.Size = new Size(422, 236);
            responseTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 102);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 5;
            label3.Text = "Conversation TextBox";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // promptTextBox
            // 
            promptTextBox.Location = new Point(17, 362);
            promptTextBox.Multiline = true;
            promptTextBox.Name = "promptTextBox";
            promptTextBox.PlaceholderText = "Hi there!";
            promptTextBox.Size = new Size(341, 52);
            promptTextBox.TabIndex = 6;
            promptTextBox.KeyPress += PromptTextBox_KeyPress;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(364, 362);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(75, 25);
            sendButton.TabIndex = 7;
            sendButton.Text = "Envoyer";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += SendButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(364, 391);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(86, 69);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(353, 23);
            modelTextBox.TabIndex = 10;
            modelTextBox.Text = "gpt4o";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 72);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 9;
            label4.Text = "Model";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SimpleNativeLLMClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 432);
            Controls.Add(modelTextBox);
            Controls.Add(label4);
            Controls.Add(clearButton);
            Controls.Add(sendButton);
            Controls.Add(promptTextBox);
            Controls.Add(label3);
            Controls.Add(responseTextBox);
            Controls.Add(apiKeyTextBox);
            Controls.Add(label2);
            Controls.Add(urlTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "SimpleNativeLLMClient";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox urlTextBox;
        private TextBox apiKeyTextBox;
        private Label label2;
        private TextBox responseTextBox;
        private Label label3;
        private TextBox promptTextBox;
        private Button sendButton;
        private Button clearButton;
        private TextBox modelTextBox;
        private Label label4;
    }
}
