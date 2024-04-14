namespace WareHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void ثبتوویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new AddProductForm();
            addForm.MdiParent = this;
            addForm.Show();
        }
    }
}