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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            int count = form2.count;
            string s = "";

            if (cb1.Checked == false && cb2.Checked == false && cb3.Checked == false && cb4.Checked == false)
            {
                MessageBox.Show("Надо ответить на вопрос !");
            }

            else
            {
                if (cb1.Checked && cb2.Checked && cb3.Checked == false && cb4.Checked == false)
                {
                    s = "Вы ответили на " + count.ToString() + " вопросов из 2";
                    MessageBox.Show("Ответ правильный!\nЭто последний вопрос.\n\n" + s, "Верный ответ!");
                    Application.Exit();
                }
                else
                {
                    count--;
                    s = "Вы ответили на " + count.ToString() + " вопросов из 2";
                    MessageBox.Show("Ответ неправильный!\nЭто последний вопрос.\n\n" + s, "Неверный ответ!");
                    Application.Exit();
                }
            }
        }
    }
}
