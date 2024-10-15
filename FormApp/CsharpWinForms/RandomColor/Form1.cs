using System.Drawing;

namespace RandomColor;

public partial class Form1 : Form
{
    char[] colorChars = "0123456abcdef".ToCharArray();
    //string colorStr = "0123456abcdef";
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        var str = "#";
        //loop
        while (str.Length < 7)
        {
            var i = new Random().Next(colorChars.Length);
            str += colorChars[i];
        }
        ////

        //Color
        var color = ColorTranslator.FromHtml(str);
        BackColor = color;

        //set random beep
        //var Hrz = new Random().Next(300, 700);
        //Console.Beep(Hrz, timer1.Interval);

        //set timer random interval
        //timer1.Interval = new Random().Next(100, 200);


    }
}