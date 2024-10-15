using System.IO;
namespace Students;

public partial class Form1 : Form
{
    string myFile = "studentsFile.txt";
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var name = textBox1.Text.Trim();
        if (name.Length is 0)
        {
            MessageBox.Show("write name");
            return;
        }

        //1
        //var fileData = "";
        //if (File.Exists(myFile))
        //    fileData = File.ReadAllText(myFile);

        //fileData += name+"\n";
        //File.WriteAllText(myFile, fileData);

        //2
        File.AppendAllText(myFile, name + "\n");

        MessageBox.Show("saved");
        textBox1.Text = "";

    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (File.Exists(myFile))
        {
            var fileData = File.ReadAllLines(myFile);
            listBox1.Items.AddRange(fileData);
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        File.WriteAllText(myFile, string.Empty);
        listBox1.Items.Clear();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        var names = listBox1.Items;
        if (names.Count is 0)
        {
            MessageBox.Show("empty listbox");
            return;
        }

        var i = new Random().Next(names.Count);
        button4.Text = (string)names[i];
        listBox1.Items.RemoveAt(i);
    }
}