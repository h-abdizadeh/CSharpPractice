namespace Guess;

public partial class Form1 : Form
{
    int goal,turn=3;
     public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        goal = new Random().Next(1, 101);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if(button1.Text is "again")
        {
            turn = 3;
            label1.Text = "START";
            goal = new Random().Next(1, 101);
            textBox1.Enabled=true;
            textBox1.Text = "";
            button1.Text = "guess";
            return;
        }

        label1.Left = -label1.Width;

        var input = textBox1.Text;
        if (string.IsNullOrEmpty(input))
        {
            MessageBox.Show("guess in textbox", "msg");
            return;
        }

        int.TryParse(input, out int guess);
        if (guess is 0)//==
        {
            MessageBox.Show("guess not valid", "msg");
            return;
        }

        if (guess < goal)
            label1.Text = "go Up";
        else if (guess > goal)
            label1.Text = "go Down";
        else
            label1.Text = "You Win";

        if(checkBox1.Checked)
        {
            turn--;
            if(turn is 0)
            {
                label1.Text = "You Lose";
                textBox1.Enabled = false;
                button1.Text = "again";
            }
        }

        timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        var l = label1.Left;
        if (l < 0)
            label1.Left += 10;
        else
            timer1.Stop();
    }
}