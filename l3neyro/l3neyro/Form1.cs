using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l3neyro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var function = new Function {
                X1 = Convert.ToDouble(textBox1.Text),
                X2 = Convert.ToDouble(textBox2.Text)
            };

            var sigma = Convert.ToDouble(textBox3.Text);
            var countOfTraining = Convert.ToInt32(textBox4.Text);

            var random = new Random();
            var listFunction = new List<Function>();

            for (int i = 0; i < countOfTraining; i++)
            {
                listFunction.Add(new Function { X1 = random.NextDouble() * -1, X2 = random.NextDouble() });
            }

            textBox5.Text = Convert.ToString(function.GetResult());
            var neuralNetwork = new NeuralNetwork();
            textBox6.Text = Convert.ToString(neuralNetwork.GetY(listFunction, function, sigma));

            foreach (var item in listFunction)
            {
                dataGridView1.Rows.Add(item.X1, item.X2);
            }

        }
    }
}
