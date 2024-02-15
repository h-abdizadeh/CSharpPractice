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

    private async void button2_Click(object sender, EventArgs e)
    {
        var note = textBox1.Text;

        var dt = DateTime.Now;
        note = $"{note}{Environment.NewLine}{dt}";//'\n'

        var persian = new PersianCalendar();
        var pdt =
            $"{persian.GetYear(dt)}/{persian.GetMonth(dt)}/{persian.GetDayOfMonth(dt)}";

        note += $"{Environment.NewLine}{pdt}{Environment.NewLine}";//\r\n

        //textBox2.Text = note;

        //File.WriteAllText(fileName, note);
        //await File.WriteAllTextAsync(fileName, note);

        //File.AppendAllText(fileName, note);
        await File.AppendAllTextAsync(fileName, note);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (!File.Exists(fileName))
        {
            File.Create(fileName).Close();//dispose
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (File.Exists(fileName))
        {
            //1
            //var fileNote = File.ReadAllText(fileName);
            //textBox2.Text = fileNote;

            //2
            var fileLines = File.ReadAllLines(fileName);
            //textBox2.Text = fileLines;//error
            //A
            //textBox2.Text = string.Join("\r\n", fileLines);

            //B
            foreach (var item in fileLines)
            {
                textBox2.Text += $"\r\n{item}";
            }
        }
    }
}