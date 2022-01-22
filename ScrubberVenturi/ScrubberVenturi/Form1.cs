using System;
using System.Windows.Forms;
using System.IO;

namespace ScrubberVenturi
{
    public partial class Form1 : Form
    {
        private Scrubber scrubber;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Иницируем класс
            scrubber = new Scrubber();

            // Передаем в класс, то что ввел пользователь
            scrubber.V = Convert.ToDouble(Vz.Value);
            scrubber.w = Convert.ToDouble(w.Value);
            scrubber.w1 = Convert.ToDouble(w1.Value);
            scrubber.Vb = Convert.ToDouble(Vb.Value);
            scrubber.h = Convert.ToDouble(h.Value);
            scrubber.pb = Convert.ToDouble(pb.Value);
            scrubber.K = Convert.ToDouble(K.Value);


            result.Text = "";
            // Манипуляции с кнопкой, меняем текст и отключаем
            calc.Text = "Создаем...";
            calc.Enabled = false;
            
            // Вызываем метод, в котором должны быть расчеты
            scrubber.calc();

            // Пробуем создать модель
            if (scrubber.createModel())
            {
                MessageBox.Show("Модель создана");
                save.Enabled = true;
                result.Text = scrubber.result;
            }
            else
            {
                save.Enabled = false;
                MessageBox.Show("Произошла ошибка");
            }

            // Возращаем исходное состоянии кнопки
            calc.Text = "Создать";
            calc.Enabled = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            //диалог для сохранения подсчетов
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //фильтр файлов для диалога
            saveFileDialog1.Filter = "Txt|*.txt";
            //отображаем диалог
            saveFileDialog1.ShowDialog();
            //если имя сохраняемого файла не пустое
            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    //сохранение в файл
                    File.WriteAllText(saveFileDialog1.FileName, scrubber.result);
                    MessageBox.Show("Сохранено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        // При клике открываем вторую форму
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterParent;
            form2.ShowDialog(this);
            this.Visible = false;
            Hide();
        }
        // Кнопка выхода из программы
        private void button2_Click(object sender, EventArgs e)
        {          
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

            if (result == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
