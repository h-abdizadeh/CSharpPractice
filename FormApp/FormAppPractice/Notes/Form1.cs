using System.Globalization;//persian calendar
//using System.IO;//File

namespace Notes;

public partial class Form1 : Form
{
    string fileName = "myFile.txt";
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var note = textBox1.Text;

        var dt = DateTime.Now;
        note = $"{note}{Environment.NewLine}{dt}";//'\n'

        var persian = new PersianCalendar();
        var pdt =
            $"{persian.GetYear(dt)}/{persian.GetMonth(dt)}/{persian.GetDayOfMonth(dt)}";

        note += $"{Environment.NewLine}{pdt}";

        textBox2.Text = note;


    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if(!File.Exists(fileName))
        {
            File.Create(fileName).Close();//dispose
        }
    }
}