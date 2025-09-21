using System.Text.Json;
using System.Xml.Serialization;
using JsonXmlFile.models;

namespace JsonXmlFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = new Person
            {
                name = "amir",
                age = 18,
                phone = "0911"
            };

            var jsondata = JsonSerializer.Serialize(data);
            File.WriteAllText("myjson.json", jsondata);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var jsonFile = "myjson.json";
            if (File.Exists(jsonFile))
            {
                var jsondata = File.ReadAllText(jsonFile);
                var data = JsonSerializer.Deserialize<Person>(jsondata);

                MessageBox.Show(data.name);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var persons = new List<Person>
            {
                new Person{ name="amir",age=15,phone="0912"},
                new Person{ name="sara",age=17,phone="0932"},
                new Person{ name="arad",age=14,phone="0910"}
            };

            var jsondata = JsonSerializer.Serialize(persons);
            File.WriteAllText("myjson.json", jsondata);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var jsonFile = "myjson.json";
            if (File.Exists(jsonFile))
            {
                var data = File.ReadAllText(jsonFile);

                var option = new JsonSerializerOptions()
                {
                    WriteIndented = true,
                };

                var datalist =
                    JsonSerializer.Deserialize<List<Person>>(data, option);

                dataGridView1.DataSource = datalist;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = new Person
            {
                name = "amir",
                age = 18,
                phone = "0911"
            };

            var xmldata = new XmlSerializer(typeof(Person));
            using (var stream = new FileStream("myxml.xml", FileMode.Create))
            {
                xmldata.Serialize(stream, data);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var persons = new List<Person>
            {
                new Person{ name="amir",age=15,phone="0912"},
                new Person{ name="sara",age=17,phone="0932"},
                new Person{ name="arad",age=14,phone="0910"}
            };

            var xmldata = new XmlSerializer(typeof(List<Person>));
            using (var stream = new FileStream("myxml.xml", FileMode.Create))
            {
                xmldata.Serialize(stream, persons);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var xml = new XmlSerializer(typeof(List<Person>));

            using(var stream=new FileStream("myxml.xml", FileMode.Open))
            {
               var result= xml.Deserialize(stream);

                dataGridView1.DataSource = result;
            }
        }
    }
}
