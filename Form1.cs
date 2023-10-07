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
        public void button1_Click(object sender, EventArgs e)
        {
            string? selectedTask = textBox1.Text;
            if (string.IsNullOrEmpty(selectedTask))
            {
                errorProvider1.SetError(textBox1, "Task is required");
            }
            else
            {
                DateOnly date = DateOnly.FromDateTime(DateTime.Now);
                ToDoList.Items.Add(selectedTask + $" {date}");
            }
        }
        public void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToDoList.Items.Count < 0)
            {
                errorProvider1.SetError(textBox1, "No tasks");
            }
            else
            {
                string? selectedDo = ToDoList.GetItemText(ToDoList.SelectedItem);
                InProgressList.Items.Add(selectedDo);
                ToDoList.Items.Remove(selectedDo);
            }
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
            progressBar1.Value += 1;
            if (progressBar1.Value >= 3)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = Image.FromFile(@"F:\\MVS Projects\\HeroTasker\\Enemy\\HURT_0001w2.png");
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                progressBar1.Maximum += 2;
            }
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Black;
        }
    }
}