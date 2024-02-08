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
    bool newNumber = true,finalResult=false;

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

        finalResult = false;

        if (input.Contains('.'))
            return double.Parse(input).ToString();
        else
            return double.Parse(input).ToString("n0");

    }

    private void buttonSum_Click(object sender, EventArgs e)
    {
        if (finalResult)
        {
            input = labelScreen.Text.Replace(",", "");
        }
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
        if (result.ToString().Contains('.'))
            labelScreen.Text = result.ToString();
        else
            labelScreen.Text = result.ToString("n0");

        

        newNumber = true;
        finalResult = true;
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
        newNumber = false;
        finalResult = false;

        //if (!input.Contains('.'))
        //if (input.Contains('.') != true)
        //if (input.Contains('.') == false)
        if (input.Contains('.') is false)
            return input += '.';
        //else
        return input;

    }

    private void button3_Click(object sender, EventArgs e)
    {
        labelScreen.Text = InputNumber(labelScreen.Text, button3.Text);
    }

    private void button4_Click(object sender, EventArgs e)
    {
        labelScreen.Text = InputNumber(labelScreen.Text, button4.Text);
    }

    private void button5_Click(object sender, EventArgs e)
    {
        labelScreen.Text = InputNumber(labelScreen.Text, button5.Text);
    }

    private void button6_Click(object sender, EventArgs e)
    {
        labelScreen.Text = InputNumber(labelScreen.Text, button6.Text);
    }

    private void button7_Click(object sender, EventArgs e)
    {
        labelScreen.Text = InputNumber(labelScreen.Text, button7.Text);
    }

    private void button8_Click(object sender, EventArgs e)
    {
        labelScreen.Text = InputNumber(labelScreen.Text, button8.Text);
    }

    private void button9_Click(object sender, EventArgs e)
    {
        labelScreen.Text = InputNumber(labelScreen.Text, button9.Text);
    }

    private void button0_Click(object sender, EventArgs e)
    {
        labelScreen.Text = InputNumber(labelScreen.Text, button0.Text);
    }

    private void buttonMinus_Click(object sender, EventArgs e)
    {
        if (finalResult)
        {
            input = labelScreen.Text.Replace(",", "");
        }
        num1 = double.Parse(input);
        opr = buttonMinus.Text;
        newNumber = true;
    }

    private void buttonDiv_Click(object sender, EventArgs e)
    {
        if (finalResult)
        {
            input = labelScreen.Text.Replace(",", "");
        }
        num1 = double.Parse(input);
        opr = buttonDiv.Text;
        newNumber = true;
    }

    private void buttonMult_Click(object sender, EventArgs e)
    {
        if (finalResult)
        {
            input = labelScreen.Text.Replace(",", "");
        }
        num1 = double.Parse(input);
        opr = buttonMult.Text;
        newNumber = true;
        finalResult = false;
    }
}