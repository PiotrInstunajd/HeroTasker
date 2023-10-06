using System.CodeDom;

namespace HeroTasker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToDoList.CheckOnClick = true;
            InProgressList.CheckOnClick = true;
            DoneList.CheckOnClick = true;
            progressBar1.Maximum = 5;
            progressBar1.Minimum = 0;
            textBox1.Text = "Insert Task Here";
            textBox1.ForeColor = System.Drawing.Color.Gray;
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