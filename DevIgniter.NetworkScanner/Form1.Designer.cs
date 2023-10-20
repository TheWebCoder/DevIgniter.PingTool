namespace DevIgniter.NetworkScanner
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
            label1 = new Label();
            ipTextBox = new TextBox();
            inputButton = new Button();
            ipLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(318, 41);
            label1.Name = "label1";
            label1.Size = new Size(305, 45);
            label1.TabIndex = 1;
            label1.Text = "Enter an IP Address ";
            label1.Click += label1_Click;
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new Point(318, 121);
            ipTextBox.Margin = new Padding(3, 4, 3, 4);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(279, 27);
            ipTextBox.TabIndex = 2;
            ipTextBox.TextChanged += ipTextBox_TextChanged;
            // 
            // inputButton
            // 
            inputButton.Location = new Point(370, 199);
            inputButton.Margin = new Padding(3, 4, 3, 4);
            inputButton.Name = "inputButton";
            inputButton.Size = new Size(168, 64);
            inputButton.TabIndex = 3;
            inputButton.Text = "Ping";
            inputButton.UseVisualStyleBackColor = true;
            inputButton.Click += inputButton_Click;
            // 
            // ipLabel
            // 
            ipLabel.AutoSize = true;
            ipLabel.Location = new Point(381, 475);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(0, 20);
            ipLabel.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(370, 303);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(168, 65);
            button1.TabIndex = 5;
            button1.Text = "Get My Ip";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(370, 407);
            button2.Name = "button2";
            button2.Size = new Size(168, 65);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ipLabel);
            Controls.Add(inputButton);
            Controls.Add(ipTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Network Ping Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox ipTextBox;
        private Button inputButton;
        private Label ipLabel;
        private Button button1;
        private Button button2;
    }
}