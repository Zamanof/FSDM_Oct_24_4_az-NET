namespace NET_11._EventArgs_with_Windows_Forms
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
            AddButton = new Button();
            SubtractButton = new Button();
            MultipleButton = new Button();
            DiovideButton = new Button();
            LeftTextBox = new TextBox();
            RightTextBox = new TextBox();
            label1 = new Label();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(40, 127);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            
            // 
            // SubtractButton
            // 
            SubtractButton.Location = new Point(121, 127);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(75, 23);
            SubtractButton.TabIndex = 0;
            SubtractButton.Text = "Subtract";
            SubtractButton.UseVisualStyleBackColor = true;
            // 
            // MultipleButton
            // 
            MultipleButton.Location = new Point(202, 127);
            MultipleButton.Name = "MultipleButton";
            MultipleButton.Size = new Size(75, 23);
            MultipleButton.TabIndex = 0;
            MultipleButton.Text = "Multiple";
            MultipleButton.UseVisualStyleBackColor = true;
            // 
            // DiovideButton
            // 
            DiovideButton.Location = new Point(283, 127);
            DiovideButton.Name = "DiovideButton";
            DiovideButton.Size = new Size(75, 23);
            DiovideButton.TabIndex = 0;
            DiovideButton.Text = "Divide";
            DiovideButton.UseVisualStyleBackColor = true;
            // 
            // LeftTextBox
            // 
            LeftTextBox.Location = new Point(78, 48);
            LeftTextBox.Name = "LeftTextBox";
            LeftTextBox.Size = new Size(100, 23);
            LeftTextBox.TabIndex = 1;
            // 
            // RightTextBox
            // 
            RightTextBox.Location = new Point(202, 48);
            RightTextBox.Name = "RightTextBox";
            RightTextBox.Size = new Size(100, 23);
            RightTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 93);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Result";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(167, 93);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(13, 15);
            ResultLabel.TabIndex = 2;
            ResultLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 192);
            Controls.Add(ResultLabel);
            Controls.Add(label1);
            Controls.Add(RightTextBox);
            Controls.Add(LeftTextBox);
            Controls.Add(DiovideButton);
            Controls.Add(MultipleButton);
            Controls.Add(SubtractButton);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button SubtractButton;
        private Button MultipleButton;
        private Button DiovideButton;
        private TextBox LeftTextBox;
        private TextBox RightTextBox;
        private Label label1;
        private Label ResultLabel;
    }
}
