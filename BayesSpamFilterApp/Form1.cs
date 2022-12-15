namespace BayesSpamFilterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_checkmsg_Click(object sender, EventArgs e)
        {
            GetStemDelegate GetStem;
            SpamFilter filter = new();
            StemmerPorter porter = new();
            if (radioButton_Porter.Checked)
            {
                GetStem = porter.GetStem;
            }
            else
            {
                GetStem = porter.GetStem; // �������� �� ������ �������
            }

            filter.txtproc = new(GetStem);
        }

        class InvalidMessageException: Exception
        {

        }

    }
}