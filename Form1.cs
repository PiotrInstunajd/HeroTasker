using Microsoft.VisualBasic.ApplicationServices;
using System.CodeDom;
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
        public void button1_Click(object sender, EventArgs e)
        {
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
            string? selectedDo = ToDoList.GetItemText(ToDoList.SelectedItem);
            ToDoList.Items.Remove(selectedDo);
            InProgressList.Items.Add(selectedDo);
        }
        private void InProgressList_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            string? selectedDoneList = DoneList.GetItemText(DoneList.SelectedItem);
            ArchiveList.Items.Add(selectedDoneList);
            DoneList.Items.Remove(selectedDoneList);
            progressBar1.Value += 1;
            XP.Text = $"XP {progressBar1.Value}/{progressBar1.Maximum}";
            if (progressBar1.Value > (progressBar1.Value / 2))
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = Image.FromFile(@"F:\\MVS Projects\\HeroTasker\\Enemy\\HURT_0001w2.png");
            }
            if (progressBar1.Value < (progressBar1.Value / 2))
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(@"F:\\MVS Projects\\HeroTasker\\Enemy\\HURT_0001.png");
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                progressBar1.Maximum += 2;
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
    }
}