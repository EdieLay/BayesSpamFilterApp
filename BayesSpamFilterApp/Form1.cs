namespace BayesSpamFilterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        SpamFilter filter = new();

        private void button_checkmsg_Click(object sender, EventArgs e)
        {
            button_checkmsg.Enabled = false;
            GetStemDelegate GetStem;
            StemmerPorter porter = new();
            StemmerZ stemz = new StemmerZ();
            FilterHarshness harshness;
            if (radioButton_Porter.Checked)
            {
                GetStem = porter.GetStem;
            }
            else
            {
                GetStem = stemz.GetStem;
            }

            filter.txtproc = new(GetStem);

            Thread updating = new(filter.UpdateFrequencies);
            updating.Start();

            if (radioButton_soft.Checked)
                harshness = FilterHarshness.ћ€гкий;
            else if (radioButton_mid.Checked)
                harshness = FilterHarshness.—редний;
            else
                harshness = FilterHarshness.∆есткий;

            List<string> words_in_msg = filter.GetMessageStems(textBox_message.Text);

            updating.Join();

            if (filter.IsSpam(words_in_msg, harshness))
            {
                label_result.ForeColor = System.Drawing.Color.Red;
                label_result.Text = "спам";
            }
            else
            {
                label_result.ForeColor = System.Drawing.Color.Green;
                label_result.Text = "не спам";
            }
            button_checkmsg.Enabled = true;
        }

        class InvalidMessageException: Exception
        {

        }

    }
}