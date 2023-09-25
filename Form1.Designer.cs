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
            ToDoList = new CheckedListBox();
            InProgressList = new CheckedListBox();
            DoneList = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            AddButton = new Button();
            testLabel = new Label();
            SuspendLayout();
            // 
            // ToDoList
            // 
            ToDoList.BackColor = Color.FromArgb(128, 64, 0);
            ToDoList.FormattingEnabled = true;
            ToDoList.Location = new Point(12, 101);
            ToDoList.Name = "ToDoList";
            ToDoList.Size = new Size(190, 418);
            ToDoList.TabIndex = 0;
            ToDoList.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // InProgressList
            // 
            InProgressList.BackColor = Color.FromArgb(128, 64, 0);
            InProgressList.FormattingEnabled = true;
            InProgressList.Location = new Point(208, 101);
            InProgressList.Name = "InProgressList";
            InProgressList.Size = new Size(415, 418);
            InProgressList.TabIndex = 1;
            // 
            // DoneList
            // 
            DoneList.BackColor = Color.FromArgb(128, 64, 0);
            DoneList.FormattingEnabled = true;
            DoneList.Location = new Point(629, 101);
            DoneList.Name = "DoneList";
            DoneList.Size = new Size(190, 418);
            DoneList.TabIndex = 2;
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
            // AddButton
            // 
            AddButton.Location = new Point(10, 530);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 7;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += button1_Click;
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.Location = new Point(277, 525);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(38, 15);
            testLabel.TabIndex = 8;
            testLabel.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(117, 58, 19);
            ClientSize = new Size(831, 565);
            Controls.Add(testLabel);
            Controls.Add(AddButton);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DoneList);
            Controls.Add(InProgressList);
            Controls.Add(ToDoList);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox ToDoList;
        private CheckedListBox InProgressList;
        private CheckedListBox DoneList;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button AddButton;
        private Label testLabel;
    }
}