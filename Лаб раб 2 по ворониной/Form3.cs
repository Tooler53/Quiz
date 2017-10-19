using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб_раб_2_по_ворониной
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
                    MessageBox.Show("Ответ правильный! Переходдим к следующему вопросу.", "Верный ответ!", MessageBoxButtons.OK);
                    MessageBox.Show("Это последний вопрос.");
                    s = "Вы ответили на " + count.ToString() + " вопросов из 2";
                    MessageBox.Show(s);
                    Application.Exit();
                }
                else
                {
                    count--;
                    MessageBox.Show("Ответ неправильный! Переходим к следующему вопросу.", "Неверный ответ!", MessageBoxButtons.OK);
                    MessageBox.Show("Это последний вопрос.");
                    s = "Вы ответили на " + count.ToString() + " вопросов из 2";
                    MessageBox.Show(s);
                    Application.Exit();
                }
            }
        }
    }
}
