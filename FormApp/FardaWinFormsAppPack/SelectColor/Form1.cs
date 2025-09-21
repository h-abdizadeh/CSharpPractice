namespace SelectColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = comboBox1.SelectedIndex;
            //var item = (string)comboBox1.SelectedItem;
            var item = comboBox1.SelectedItem;

            if (index == 0)
                BackColor = Color.Red;

            //if (item == "green")
            if (item.Equals("green"))
                BackColor = Color.Green;
        }
    }
}
