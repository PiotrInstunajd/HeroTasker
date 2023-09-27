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

        }
        public void button1_Click(object sender, EventArgs e)
        {
            var list = new List<string>();
            list.Add(textBox1.Text);

            ToDoList.Items.Add(textBox1.Text);
            #region NotePad
            #endregion
        }
        public void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            InProgressList.Items.Add(ToDoList.SelectedItem);
            ToDoList.Items.Remove(InProgressList.SelectedItem);
            #region NotePad
            //if (checkedListBox1_SelectedIndexChanged)
            //{
            //    InProgressList.Items.Remove(checkedListBox1_SelectedIndexChanged);
            //}

            //ToDoList.Items.Remove(ToDoList.SelectedItem);
            //InProgressList.Items.Remove(InProgressList.SelectedItem);

            //ToDoList.GetItemChecked();
            //this.BeginInvoke(new Action(() =>
            //{
            //    InProgressList.Items.Add(ToDoList.SelectedItem);

            //}));
            #endregion
        }
        private void InProgressList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoneList.Items.Add(InProgressList.SelectedItem);
            InProgressList.Items.Remove(InProgressList.SelectedItem);
            #region NotePad
            //ID[]=IDlistBox =>removeID[]

            //foreach (var item in InProgressList.Items)
            //{
            //    if (item.Equals(null))
            //    {
            //        InProgressList.Items.Remove(item);
            //    }
            //}

            //checkedListBox3.Items.Add(this.checkedListBox2.Text);
            #endregion
        }
        private void DoneList_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region NotePad
            #endregion
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            #region NotePad
            #endregion
        }


    }
}