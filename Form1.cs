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
            string[] Tasks = new[] {""};
            checkedListBox1.Items.Add(Tasks);

            if (checkedListBox1.Item == CheckState.Checked)
            {
                checkedListBox2.Items.Add(Tasks);
            }
            //checkedListBox1.ItemCheck += (sender, e) => { checkedListBox2.Items.Add(e); };
            //checkedListBox1.Items.Remove(e);

            //35 43
        }

        public void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<string> Tasks = new List<string>();

            //checkedListBox2.ItemCheck += (sender, e) => { checkedListBox3.Items.Add(e); };

            //35 43
        }

        public void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<string> Tasks = new List<string>();

            //checkedListBox3.ItemCheck += (sender, e) => { checkedListBox2.Items.Add(e); };

            //35 43
        }

        public void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
        }
    }
}