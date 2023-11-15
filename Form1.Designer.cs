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
            XP = new Label();
            ArchiveList = new CheckedListBox();
            pictureBox2 = new PictureBox();
            MotivationL = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SettingsB = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ToDoList
            // 
            ToDoList.BackColor = Color.Black;
            ToDoList.CheckOnClick = true;
            ToDoList.Font = new Font("Viner Hand ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ToDoList.ForeColor = Color.White;
            ToDoList.FormattingEnabled = true;
            ToDoList.Location = new Point(12, 156);
            ToDoList.Name = "ToDoList";
            ToDoList.Size = new Size(190, 395);
            ToDoList.TabIndex = 0;
            ToDoList.SelectedIndexChanged += ToDoList_SelectedIndexChanged;
            // 
            // InProgressList
            // 
            InProgressList.BackColor = SystemColors.InfoText;
            InProgressList.CheckOnClick = true;
            InProgressList.Font = new Font("Viner Hand ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            InProgressList.ForeColor = Color.White;
            InProgressList.FormattingEnabled = true;
            InProgressList.Location = new Point(208, 156);
            InProgressList.Name = "InProgressList";
            InProgressList.Size = new Size(199, 395);
            InProgressList.TabIndex = 1;
            InProgressList.SelectedIndexChanged += InProgressList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(72, 34);
            label1.TabIndex = 3;
            label1.Text = "To Do";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(208, 123);
            label2.Name = "label2";
            label2.Size = new Size(126, 34);
            label2.TabIndex = 4;
            label2.Text = "In Progress";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(413, 123);
            label3.Name = "label3";
            label3.Size = new Size(67, 34);
            label3.TabIndex = 5;
            label3.Text = "Done";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(57, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "Insert Task Here";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Viner Hand ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(12, 46);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(39, 23);
            AddButton.TabIndex = 7;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += button1_Click;
            // 
            // DoneList
            // 
            DoneList.BackColor = Color.Black;
            DoneList.CheckOnClick = true;
            DoneList.Font = new Font("Viner Hand ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DoneList.ForeColor = Color.White;
            DoneList.FormattingEnabled = true;
            DoneList.Location = new Point(413, 156);
            DoneList.Name = "DoneList";
            DoneList.Size = new Size(190, 257);
            DoneList.TabIndex = 2;
            DoneList.SelectedIndexChanged += DoneList_SelectedIndexChanged;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.White;
            progressBar1.ForeColor = SystemColors.Info;
            progressBar1.Location = new Point(12, 12);
            progressBar1.Maximum = 5;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(415, 28);
            progressBar1.TabIndex = 8;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Crap;
            pictureBox1.Location = new Point(444, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 83);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // XP
            // 
            XP.AutoSize = true;
            XP.BackColor = Color.Transparent;
            XP.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            XP.Location = new Point(353, 43);
            XP.Name = "XP";
            XP.Size = new Size(0, 25);
            XP.TabIndex = 10;
            // 
            // ArchiveList
            // 
            ArchiveList.BackColor = Color.Black;
            ArchiveList.Font = new Font("Viner Hand ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ArchiveList.ForeColor = Color.White;
            ArchiveList.FormattingEnabled = true;
            ArchiveList.Location = new Point(413, 432);
            ArchiveList.Name = "ArchiveList";
            ArchiveList.Size = new Size(190, 119);
            ArchiveList.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = Properties.Resources.XwI4;
            pictureBox2.Image = Properties.Resources.XwI4;
            pictureBox2.Location = new Point(609, 349);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 200);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // MotivationL
            // 
            MotivationL.BackColor = Color.Transparent;
            MotivationL.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MotivationL.ForeColor = Color.White;
            MotivationL.ImageAlign = ContentAlignment.BottomLeft;
            MotivationL.Location = new Point(609, 241);
            MotivationL.Name = "MotivationL";
            MotivationL.Size = new Size(122, 105);
            MotivationL.TabIndex = 13;
            MotivationL.TextAlign = ContentAlignment.BottomRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // SettingsB
            // 
            SettingsB.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsB.Location = new Point(731, 7);
            SettingsB.Name = "SettingsB";
            SettingsB.Size = new Size(88, 33);
            SettingsB.TabIndex = 14;
            SettingsB.Text = "Settings";
            SettingsB.UseVisualStyleBackColor = true;
            SettingsB.Click += SettingsB_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.MenuText;
            listBox1.Font = new Font("Viner Hand ITC", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = Color.Transparent;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(718, 156);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(101, 58);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.BackBasic;
            ClientSize = new Size(831, 565);
            Controls.Add(listBox1);
            Controls.Add(SettingsB);
            Controls.Add(MotivationL);
            Controls.Add(pictureBox2);
            Controls.Add(ArchiveList);
            Controls.Add(XP);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label XP;
        private CheckedListBox ArchiveList;
        private PictureBox pictureBox2;
        private Label MotivationL;
        private System.Windows.Forms.Timer timer1;
        private Button SettingsB;
        private ListBox listBox1;
    }
}