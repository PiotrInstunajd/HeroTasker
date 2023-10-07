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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ToDoList = new CheckedListBox();
            InProgressList = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            AddButton = new Button();
            DoneList = new CheckedListBox();
            progressBar1 = new ProgressBar();
            errorProvider1 = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ToDoList
            // 
            ToDoList.BackColor = Color.FromArgb(128, 64, 0);
            ToDoList.CheckOnClick = true;
            ToDoList.FormattingEnabled = true;
            ToDoList.Location = new Point(12, 101);
            ToDoList.Name = "ToDoList";
            ToDoList.Size = new Size(190, 400);
            ToDoList.TabIndex = 0;
            ToDoList.SelectedIndexChanged += ToDoList_SelectedIndexChanged;
            // 
            // InProgressList
            // 
            InProgressList.BackColor = Color.FromArgb(128, 64, 0);
            InProgressList.CheckOnClick = true;
            InProgressList.FormattingEnabled = true;
            InProgressList.Location = new Point(208, 101);
            InProgressList.Name = "InProgressList";
            InProgressList.Size = new Size(415, 400);
            InProgressList.TabIndex = 1;
            InProgressList.SelectedIndexChanged += InProgressList_SelectedIndexChanged;
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
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(91, 530);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "Insert Task Here";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_TextChanged;
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
            // DoneList
            // 
            DoneList.BackColor = Color.FromArgb(128, 64, 0);
            DoneList.CheckOnClick = true;
            DoneList.FormattingEnabled = true;
            DoneList.Location = new Point(629, 101);
            DoneList.Name = "DoneList";
            DoneList.Size = new Size(190, 400);
            DoneList.TabIndex = 2;
            DoneList.SelectedIndexChanged += DoneList_SelectedIndexChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 12);
            progressBar1.Maximum = 5;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(415, 23);
            progressBar1.TabIndex = 8;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(433, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 83);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(117, 58, 19);
            ClientSize = new Size(831, 565);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox ToDoList;
        private CheckedListBox InProgressList;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button AddButton;
        private CheckedListBox DoneList;
        private ProgressBar progressBar1;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox1;
    }
}