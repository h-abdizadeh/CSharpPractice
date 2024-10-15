using System.IO;

namespace Theme;

public partial class Form1 : Form
{
    string myFile = "themeFile.txt";
    public Form1()
    {
        InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBox1.SelectedIndex == 0)
            BackColor = Color.Green;
        else if (comboBox1.SelectedIndex == 1)
            BackColor = Color.Red;
        else if (comboBox1.SelectedIndex == 2)
            BackColor = Color.Blue;
        else if (comboBox1.SelectedIndex == 3)
            BackColor = Color.Teal;
        else if (comboBox1.SelectedIndex == 4)
            BackColor = Color.Black;

        File.WriteAllText(myFile, (string)comboBox1.SelectedItem);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (File.Exists(myFile))
        {
            var fileText = File.ReadAllText(myFile);

            if (fileText is "green")
                BackColor = Color.Green;
            else if (fileText is "blue")
                BackColor = Color.Blue;
            else if (fileText is "red")
                BackColor = Color.Red;
            else if (fileText is "teal")
                BackColor = Color.Teal;
            else if (fileText is "black")
                BackColor = Color.Black;
        }
    }
}