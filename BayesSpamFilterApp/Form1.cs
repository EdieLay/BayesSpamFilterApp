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
            GetStemDelegate GetStem;
            StemmerPorter porter = new();
            FilterHarshness harshness;
            if (radioButton_Porter.Checked)
            {
                GetStem = porter.GetStem;
            }
            else
            {
                GetStem = porter.GetStem; // ÇÀÌÅÍÈÒÜ ÍÀ ÄĞÓÃÎÉ ÑÒÅÌÌÅĞ
            }

            filter.txtproc = new(GetStem);

            Thread updating = new(filter.UpdateFrequencies);
            updating.Start();

            if (radioButton_soft.Checked)
                harshness = FilterHarshness.Ìÿãêèé;
            else if (radioButton_mid.Checked)
                harshness = FilterHarshness.Ñğåäíèé;
            else
                harshness = FilterHarshness.Æåñòêèé;

            List<string> words_in_msg = filter.GetMessageStems(textBox_message.Text);

            updating.Join();

            if (filter.IsSpam(words_in_msg, harshness))
            {
                label_result.ForeColor = System.Drawing.Color.Red;
                label_result.Text = "ñïàì";
            }
            else
            {
                label_result.ForeColor = System.Drawing.Color.Green;
                label_result.Text = "íå ñïàì";
            }
        }

        class InvalidMessageException: Exception
        {

        }

    }
}