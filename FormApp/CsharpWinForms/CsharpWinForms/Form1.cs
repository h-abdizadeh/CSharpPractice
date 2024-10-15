namespace CsharpWinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        MessageBox.Show("خوش آمدید", "پیغام");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (button2.Visible)//==true
            button2.Visible = false;
        else
            button2.Visible = true;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBox1.SelectedIndex is 0)//==
            comboBox1.BackColor = Color.Red;
        if (comboBox1.SelectedItem is "green")
            comboBox1.BackColor = Color.Green;
        if (comboBox1.SelectedIndex is 2)
            comboBox1.BackColor = Color.Yellow;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var count = int.Parse(button3.Text);
        count++;
        button3.Text = count.ToString();
    }
}