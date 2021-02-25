using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RSK_2_21_Lect1_Console;

namespace RSK_2_21_L1_WF
{
    public partial class Form1 : Form
    {
        enum Operation
        {
            Add, Sub, Mult, Abs, Nop
        }

        public Form1()
        {
            InitializeComponent();


            cbOperator.DataSource = Enum.GetValues(typeof(Operation));
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world", "RSK-21");
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var a = MyComplex.ParseComplex(tbValueA.Text);
                var b = MyComplex.ParseComplex(tbValueB.Text);

                var op = (Operation)cbOperator.SelectedItem;

                var res = new MyComplex();

                switch (op)
                {
                    case Operation.Add:
                        res = a + b;
                        break;
                    case Operation.Abs:
                        res.x = a.Abs();
                        break;
                    default:
                        
                        break;
                }

                tbResult.Text = res.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!!!");
                tbResult.Text = "";
            }
            finally
            {

            }
        }

        FormAbout formAbout;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Проверить существует ли форма
            if(formAbout == null)
            {
                formAbout = new FormAbout();
                formAbout.ShowDialog();

                if(formAbout.DialogResult == DialogResult.OK)
                {
                    tbResult.Text = formAbout.GetStringField;
                }
            }
        }

        /*
          Домашнее задание
         Отдельная форма
        Фон
        Информация о группе 
        Музыка
        Ссылка на ресурс
        Часы
        Потапов- Конвертор pdf2doc
        Вывод в текстовый файл
        Кнопки
        Github - project manager Potapov

        Добавить операторы в MyComplex
         */

    }
}
