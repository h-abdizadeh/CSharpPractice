using System.Globalization;
using System.Text.Json;

namespace Notes;

public partial class Form1 : Form
{
    string myFile = "notesFile.txt";
    string jsonFile = "noteFile.json";
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var text = textBox1.Text.Trim();
        if (text.Length is 0)
        {
            MessageBox.Show("error");
            return;
        }

        var date = DateTime.Now;
        var persian = new PersianCalendar();

        var pDate =
            $"{persian.GetYear(date)}/{persian.GetMonth(date)}/{persian.GetDayOfMonth(date)}";

        var time = TimeOnly.FromDateTime(date);


        pDate = $"{pDate} {time}";
        /// file
        /// //text += "\n" + pDate;

        //File.AppendAllText(myFile, $"{text}\n");

        // json (class model)
        var note = new Note()
        {
            date = pDate,
            description = text
        };

        var noteList = new List<Note>();
        noteList = GetJsonFile(jsonFile);
        noteList.Add(note);

        var jsonData =
            JsonSerializer.Serialize<List<Note>>(noteList);
        //MessageBox.Show(jsonData);

        File.WriteAllText(jsonFile, jsonData);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        //if (File.Exists(myFile))
        //{
        //    var fileData = File.ReadAllLines(myFile);
        //    textBox2.Text = string.Join("\r\n", fileData);
        //}

        textBox2.Text = "";
        var data = GetJsonFile(jsonFile);
        if (data is null) return;

        foreach (var note in data)
        {
            textBox2.Text += $"{note.description}\r\n{note.date}\r\n";
            //textBox2.Text += note.description + "\r\n" + note.date + "\r\n";
        }


    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //textBox2.Text = DateTime.Now.ToString();

        //if (File.Exists(myFile))
        //{
        //    var fileData = File.ReadAllLines(myFile);
        //    var dateLines =
        //        fileData.Where(f => f.Contains("/")).ToArray();
        //    comboBox1.Items.AddRange(dateLines);
        //}

        var data = GetJsonFile(jsonFile);
        if (data is null) return;

        var dateList = data.Select(d => d.date).ToArray();
        comboBox1.Items.AddRange(dateList);
    }

    private List<Note> GetJsonFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            var fileData = File.ReadAllText(fileName);
            var dataList =
                JsonSerializer.Deserialize<List<Note>>(fileData);

            return dataList;
        }

        return null;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var dataList = GetJsonFile(jsonFile);
        var date = (string)comboBox1.SelectedItem;

        var note = dataList.FirstOrDefault(n => n.date == date);
        textBox2.Text = note.description;
    }
}

