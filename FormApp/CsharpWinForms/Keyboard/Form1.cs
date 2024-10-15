using static System.Console;

namespace Keyboard;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        //white1
        if (e.KeyCode is Keys.Z)
        {
            Beep(300, 100);
            btnWhite1.BackColor = Color.Yellow;
        }
        else
        {
            btnWhite1.BackColor = Color.White;
        }

        //white2
        if (e.KeyCode is Keys.X)
        {
            Beep(400, 100);
            btnWhite2.BackColor = Color.Yellow;
        }
        else
        {
            btnWhite2.BackColor = Color.White;
        }

        //white2
        if (e.KeyCode is Keys.S)
        {
            Beep(1000, 100);
            btnBlack1.BackColor = Color.LightPink;
        }
        else
        {
            btnBlack1.BackColor = Color.Black;
        }

    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
        //if (e.KeyChar is 'z')
        //{
        //    Beep(300, 100);
        //}
    }

    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
        //if (e.KeyCode is Keys.Z)
        //{
        //    Beep(300, 100);
        //}
    }
}