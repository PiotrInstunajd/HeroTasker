using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom;
using System.Drawing;
using System.Security.Policy;

namespace HeroTasker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DateOnly date = DateOnly.FromDateTime(DateTime.Now);
        public Random rand = new Random();
        public void button1_Click(object sender, EventArgs e)
        {
            //Add task to ToDoList
            string? selectedTask = textBox1.Text;
            if (string.IsNullOrEmpty(selectedTask))
            {
                errorProvider1.SetError(textBox1, "Task is required");
            }
            else
            {
                ToDoList.Items.Add(selectedTask + $" {date}");
            }
        }
        public void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add task to InProgressList and remove from ToDoList
            //Additional error 
            string? selectedDo = ToDoList.GetItemText(ToDoList.SelectedItem);
            ToDoList.Items.Remove(selectedDo);
            InProgressList.Items.Add(selectedDo);
        }
        private void InProgressList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add task to DoneList and remove from InProgressList
            //Additional error 
            if (InProgressList.Items.Count < 0)
            {
                errorProvider1.SetError(textBox1, "No tasks");
            }
            else
            {
                string? selectedInProgress = InProgressList.GetItemText(InProgressList.SelectedItem);
                DoneList.Items.Add(selectedInProgress);
                InProgressList.Items.Remove(selectedInProgress);
            }
        }
        private void DoneList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add task to ArchiveList and remove from DoneList
            //XPText update depends on progressBar
            //Raise value in progressBar depends on amount of tasks checked
            //Changes of gif after reach maxValue
            string? selectedDoneList = DoneList.GetItemText(DoneList.SelectedItem);
            ArchiveList.Items.Add(selectedDoneList);
            DoneList.Items.Remove(selectedDoneList);
            progressBar1.Value += 1;
            progressBar1.ForeColor = Color.Crimson;
            XP.Text = $"XP {progressBar1.Value}/{progressBar1.Maximum}";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                progressBar1.Maximum += 2;
                var files = Directory.GetFiles("F:\\MVS Projects\\HeroTasker\\Sprites\\Enemy", "*.gif");
                pictureBox1.ImageLocation = files[rand.Next(files.Length)];
            }
            //if (DoneList.Items.Contains(date.CompareTo(DateTime.Now) < 1))
            //{
            //    ArchiveList.Items.Add(CheckState.Checked);
            //}
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] motivQuote = { "Just roll", "Always is a good moment for estus", "Everybody can drop soul", "Your allies are your souls", "Heavier it is harder it hits" };
            MotivationL.Text = motivQuote[rand.Next(motivQuote.Length)];
        }
    }
}