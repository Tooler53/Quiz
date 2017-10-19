using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int count = 2;

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            Form2 form2 = new Form2();

            if (rb1.Checked == false && rb2.Checked == false && rb3.Checked == false && rb4.Checked == false && rb5.Checked == false)
            {
                MessageBox.Show("Надо ответить на вопрос !");
            }

            else
            {
                if (rb1.Checked)
                {
                    MessageBox.Show("Ответ правильный! Переходдим к следующему вопросу.", "Верный ответ!", MessageBoxButtons.OK);
                    form2.Close();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    count--;
                    MessageBox.Show("Ответ неправильный! Переходим к следующему вопросу.", "Неверный ответ!", MessageBoxButtons.OK);
                    form3.Show();
                    this.Hide();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
            rb5.Checked = false;
        }
    }
}
