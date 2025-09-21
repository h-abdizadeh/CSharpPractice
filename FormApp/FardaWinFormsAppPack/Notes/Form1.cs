//using System.IO;

using Notes.Models;
using System.Text.Json;

namespace Notes;

public partial class Form1 : Form
{
    string myfile = "notefile.txt";
    string jsonFile = "jsonNotes.json";
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        ///save as  .txt file
        var note = "\n" + textBox1.Text;
        var date = DateTime.Now;
        note += "\n" + date;

        //File.WriteAllText(myfile, "note");
        File.AppendAllText(myfile, note);

    }

    private void button2_Click(object sender, EventArgs e)
    {
        //show .txt file data
        if (File.Exists(myfile))
        {
            //1
            //var notes = File.ReadAllText(myfile);
            //textBox1.Text = notes;

            //2
            var lines = File.ReadAllLines(myfile);
            //textBox1.Text = string.Join("\r\n", lines);
            foreach (var item in lines)
            {
                textBox1.Text += "\r\n" + item;
            }

        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (!File.Exists(myfile))
        {
            //File.Create(myfile).Close();
            File.Create(myfile).Dispose();
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        var note = new Note()
        {
            noteText = textBox1.Text,
            noteDate = DateTime.Now.ToString()
        };

        var json = JsonSerializer.Serialize(note);
        File.WriteAllText(jsonFile, json);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (File.Exists(jsonFile))
        {
            var data = File.ReadAllText(jsonFile);
            var notes = JsonSerializer.Deserialize<Note>(data);
            //textBox1.Text = data;
            //MessageBox.Show(notes.noteText);
            //MessageBox.Show(notes.noteDate);
            dataGridView1.DataSource = notes;
        }
    }
}
