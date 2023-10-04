namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Student ID", 150);
            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Surname", 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, name, surname;
            id = textBox1.Text;
            name = textBox2.Text;
            surname = textBox3.Text;

            string[] info = { id, name, surname };
            ListViewItem item = new ListViewItem(info);
            listView1.Items.Add(item);
        }
    }
}