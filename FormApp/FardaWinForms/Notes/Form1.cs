using System.Drawing;

namespace Notes;

public partial class Form1 : Form
{
    string themefile = "theme.txt";
    string notefile = "notes.txt";
    public Form1()
    {
        InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var color = (string?)comboBox1.SelectedItem;

        switch (color)
        {
            case "red": BackColor = Color.Red; break;
            case "blue": BackColor = Color.Blue; break;
            case "green": BackColor = Color.Green; break;
            case "teal": BackColor = Color.Teal; break;
        }

        BackColor = (color) switch
        {
            "red" => Color.Red,
            "blue" => Color.Blue,
            "green" => Color.Green,
            "teal" => Color.Teal,
            _ => SystemColors.Control
        };

        File.WriteAllText(themefile, color);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (File.Exists(themefile))
        {
            var color = File.ReadAllText(themefile);

            BackColor = (color) switch
            {
                "red" => Color.Red,
                "blue" => Color.Blue,
                "green" => Color.Green,
                "teal" => Color.Teal,
                _ => SystemColors.Control
            };
        }


        if (!File.Exists(notefile))
        {
            File.Create(notefile).Close();//Dispose();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var note = textBox1.Text.Trim();
        if (note.Length == 0)
            MessageBox.Show("چیزی بنویسید");
        else
        {
            File.AppendAllText(notefile, note + "\n");
        }

    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (File.Exists(notefile))
        {
            //1
            //var n = File.ReadAllText(notefile);
            //textBox2.Text = n;

            //2
            var notes = File.ReadAllLines(notefile);
            //textBox2.Text = String.Join("\r\n", notes);

            textBox2.Text = "";
            foreach (var n in notes)
            {
                //textBox2.Text = textBox2.Text +"\r\n"+ n;
                textBox2.Text += "\r\n" + n;
            }
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var dialog =
            MessageBox.Show("مطمئن هستید؟", 
                            "هشدار",
                            MessageBoxButtons.OKCancel);

        if (dialog == DialogResult.OK)
        {
            if (File.Exists(notefile))
            {
                //delete note (not file)
                File.WriteAllText(notefile, "");

                //delete file
                //File.Delete(notefile);
            }
        }
    }
}
