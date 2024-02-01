namespace MiniCalculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    string input = "0";
    double num1 = 0, num2 = 0;
    string opr = "";
    bool newNumber = true;

    private void button1_Click(object sender, EventArgs e)
    {
        labelScreen.Text = InputNumber(labelScreen.Text, button1.Text);
    }

    string InputNumber(string screen, string btnText)
    {
        if (screen is "0" || newNumber)
        {
            input = btnText;
            newNumber = false;
        }
        else
        {
            input += btnText;
        }

        if (input.Contains('.'))
            return double.Parse(input).ToString();
        else
            return double.Parse(input).ToString("n0");
    }

    private void buttonSum_Click(object sender, EventArgs e)
    {
        num1 = double.Parse(input);
        opr = buttonSum.Text;
        newNumber = true;
    }

    private void buttonResult_Click(object sender, EventArgs e)
    {
        //1
        num2 = double.Parse(input);

        //2
        var result = opr switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "×" => num1 * num2,
            "÷" => num1 / num2,
            _ => 0
        };

        //3
        labelScreen.Text = result.ToString("n0");
        newNumber = true;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        labelScreen.Text = InputNumber(labelScreen.Text, button2.Text);
    }

    private void buttonFloat_Click(object sender, EventArgs e)
    {
        labelScreen.Text = InputFloat();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    string InputFloat()
    {
        //if (!input.Contains('.'))
        //if (input.Contains('.') != true)
        //if (input.Contains('.') == false)
        if (input.Contains('.') is false)
            return input += '.';
        //else
        return input;

    }
}
