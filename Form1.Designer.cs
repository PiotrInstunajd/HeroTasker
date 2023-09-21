namespace HeroTasker
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
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            checkedListBox3 = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.FromArgb(128, 64, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 101);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(190, 418);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // checkedListBox2
            // 
            checkedListBox2.BackColor = Color.FromArgb(128, 64, 0);
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(208, 101);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(415, 418);
            checkedListBox2.TabIndex = 1;
            // 
            // checkedListBox3
            // 
            checkedListBox3.BackColor = Color.FromArgb(128, 64, 0);
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Location = new Point(629, 101);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(190, 418);
            checkedListBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 3;
            label1.Text = "To Do";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(208, 68);
            label2.Name = "label2";
            label2.Size = new Size(123, 30);
            label2.TabIndex = 4;
            label2.Text = "In Progress";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(629, 68);
            label3.Name = "label3";
            label3.Size = new Size(65, 30);
            label3.TabIndex = 5;
            label3.Text = "Done";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 530);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(10, 530);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(117, 58, 19);
            ClientSize = new Size(831, 565);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkedListBox3);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
    }
}