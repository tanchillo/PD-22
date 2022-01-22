using System;
using System.Windows.Forms;
using System.IO;

namespace ScrubberVenturi
{
    public partial class Form2 : Form
    {
        private Scrubber scrubber;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Иницируем класс
            scrubber = new Scrubber();

            // Передаем в класс, то что ввел пользователь
            scrubber.Dg = Convert.ToDouble(Dg.Value);
            scrubber.Ld = Convert.ToDouble(Ld.Value);
            scrubber.L1 = Convert.ToDouble(L1.Value);
            scrubber.L2 = Convert.ToDouble(L2.Value);
            scrubber.D1 = Convert.ToDouble(D1.Value);
            scrubber.D2 = Convert.ToDouble(D1.Value);
            scrubber.Dk = Convert.ToDouble(Dk.Value);
            scrubber.Hk = Convert.ToDouble(Hk.Value);
            scrubber.Dok = Convert.ToDouble(Dok.Value);

            result.Text = "";
            // Манипуляции с кнопкой, меняем текст и отключаем
            calc.Text = "Создаем...";
            calc.Enabled = false;
            
            // Вызываем метод, в котором должны быть расчеты
            scrubber.calc2();

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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        
    }
}
