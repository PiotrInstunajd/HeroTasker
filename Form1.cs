namespace HeroTasker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 


        }

        public void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToDoList.GetItemChecked(InProgressList.Items.Add(ToDoList.SelectedItem));

            
            //this.BeginInvoke(new Action(() =>
            //{
            //    InProgressList.Items.Add(ToDoList.SelectedItem);
                
            //}));
            
        }

        public void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (InProgressList.Items.Count > )
                InProgressList.Items.Remove(InProgressList.SelectedItem);



                //checkedListBox3.Items.Add(this.checkedListBox2.Text);
            }

        public void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            ToDoList.Items.Add(textBox1.Text);
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}