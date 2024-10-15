namespace LoadJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openfile = new OpenFileDialog()
            {
                Filter = "(*.json)|*.json"
            };

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                var file = openfile.FileName;
                var fileData = textBox1.Text = File.ReadAllText(file);
                var lines = fileData.Split(',');

                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = lines[i].Replace("{", "");
                    lines[i] = lines[i].Replace("}", "");
                    lines[i] = lines[i].Trim().Substring(0, lines[i].IndexOf(":"));
                }

                comboBox1.Items.AddRange(lines);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var key = (string)comboBox1.SelectedItem;
            var value = textBox2.Text;

            var jsonData = textBox1.Text;
            var newJson = "";
            var lines = jsonData.Split(",");

            foreach (var line in lines)
            {
                var endChar = line == lines.Last() ? "," : ",";
                if (line.Contains(key)){
                    var startIndex = line.IndexOf(':');
                    var l = line.Remove(startIndex + 1)+endChar;
                    l += $"\"{value}\"";
                    newJson += $"{l}{endChar}";
                }
                else
                {
                    newJson += $"{line}{endChar}";
                }           
            }

            textBox1.Text= newJson;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var key = (string)comboBox1.SelectedItem;

            //textBox1.SelectionStart = textBox1.Text.IndexOf(key);
            //textBox1.SelectionLength = key.Length;

            textBox1.Focus();
            textBox1.Select(textBox1.Text.IndexOf(key), key.Length);
        }
    }
}