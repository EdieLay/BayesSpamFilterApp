using System.Windows.Forms;

namespace BayesSpamFilterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpamFilter filter = new();

        GetStemDelegate GetStem;

        StemmerPorter porter = new();
        StemmerZ stemz = new();
        StemmerStemka stemka = new();

        FilterHarshness harshness;

        private void button_checkmsg_Click(object sender, EventArgs e)
        {
            button_checkmsg.Enabled = false; // делаем кнопку неактивной
            label_result.ForeColor = System.Drawing.Color.Gray;
            label_result.Text = "загрузка";

            if (radioButton_Porter.Checked) // ИСПОЛЬЗОВАНИЕ ДЕЛЕГАТА
                GetStem = porter.GetStem;
            else if(radioButton_Z.Checked)
                GetStem = stemz.GetStem;
            else
                GetStem = stemka.GetStem;

            filter.txtproc = new(GetStem);


            Thread updating = new(filter.UpdateFrequencies); // ИСПОЛЬЗОВАНИЕ ПОТОКОВ
            updating.Start();

            if (radioButton_soft.Checked) // ИСПОЛЬЗОВАНИЕ ПЕРЕЧИСЛЕНИЯ
                harshness = FilterHarshness.Мягкий;
            else if (radioButton_mid.Checked)
                harshness = FilterHarshness.Средний;
            else
                harshness = FilterHarshness.Жесткий;

            List<string> words_in_msg = new();
            try
            {
                words_in_msg = filter.GetMessageStems(textBox_message.Text);
            }
            catch(InvalidMessageException ex) // ИСПОЛЬЗОВАНИЕ ИСКЛЮЧЕНИЯ
            {
                label_result.Text = "";
                MessageBox.Show(ex.Message, "Ошибка!");
                updating.Join();
                button_checkmsg.Enabled = true;
                return;
            }

            updating.Join();

            double prob;
            if ((prob = filter.ProbOfSpam(words_in_msg)) >= (double)harshness/100.0)
            {
                label_result.ForeColor = System.Drawing.Color.Red;
                label_result.Text = $"спам\n{prob*100:f2}%";
            }
            else
            {
                label_result.ForeColor = System.Drawing.Color.Green;
                label_result.Text = $"не спам\n{prob*100:f2}%";
            }
            button_checkmsg.Enabled = true;
        }

        private void button_file_Click(object sender, EventArgs e)
        {
            openFileDialog_file.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog_file.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog_file.FileName; // получаем имя выбранного файла
            string message = File.ReadAllText(filename); // читаем файл в строку
            textBox_message.Text = message; // записываем её в основное поле набора текста
        }
    }
}