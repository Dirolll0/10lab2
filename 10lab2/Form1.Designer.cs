namespace _10lab2
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
            durationTextBox = new TextBox();
            nightTimeCheckBox = new CheckBox();
            Считать = new Button();
            resultLabel = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // durationTextBox
            // 
            durationTextBox.Location = new Point(316, 86);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(100, 23);
            durationTextBox.TabIndex = 0;
            durationTextBox.TextChanged += durationTextBox_TextChanged;
            // 
            // nightTimeCheckBox
            // 
            nightTimeCheckBox.AutoSize = true;
            nightTimeCheckBox.Location = new Point(316, 129);
            nightTimeCheckBox.Name = "nightTimeCheckBox";
            nightTimeCheckBox.Size = new Size(55, 19);
            nightTimeCheckBox.TabIndex = 1;
            nightTimeCheckBox.Text = "Ночь";
            nightTimeCheckBox.UseVisualStyleBackColor = true;
            nightTimeCheckBox.CheckedChanged += nightTimeCheckBox_CheckedChanged;
            // 
            // Считать
            // 
            Считать.Location = new Point(316, 163);
            Считать.Name = "Считать";
            Считать.Size = new Size(75, 23);
            Считать.TabIndex = 2;
            Считать.Text = "Считать";
            Считать.UseVisualStyleBackColor = true;
            Считать.Click += button1_Click;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(316, 192);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(102, 39);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 89);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 4;
            label1.Text = "Кол-во минут";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(resultLabel);
            Controls.Add(Считать);
            Controls.Add(nightTimeCheckBox);
            Controls.Add(durationTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox durationTextBox;
        private CheckBox nightTimeCheckBox;
        private Button Считать;
        private RichTextBox resultLabel;
        private Label label1;
    }
}
