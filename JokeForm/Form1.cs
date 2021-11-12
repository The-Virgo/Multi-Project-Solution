using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChuckNorrisAPI;
using System.Threading.Tasks;
using System.Linq;

namespace JokeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            IEnumerable<string> cats = await ChuckNorrisClient.GetCategories();
            comboBox1.DataSource = cats;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string cat = comboBox1.Text;
            Joke j = await ChuckNorrisClient.GetJokeByCategory(cat);

            textBox1.Text = j.JokeText;
        }
    }
}
