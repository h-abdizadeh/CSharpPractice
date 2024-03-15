using InterfaceClass.classes;

namespace InterfaceClass;

public partial class Form1 : Form
{
    ICode _code;


    public Form1(ICode code)
    {
        InitializeComponent();
        _code = code;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var n = double.Parse(textBox1.Text);
        var m = double.Parse(textBox2.Text);

        var result = _code.Sum(n, m);

        label1.Text = result.ToString();
    }
}