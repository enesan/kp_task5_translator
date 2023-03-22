namespace translate
{
    public partial class Form1 : Form
    {
        string[] russian;
        string[] english;
        string[] deutsch;

        public Form1()
        {
            russian = new[] { "собака", "кошка", "газета", "привет", "вода" };
            english = new[] { "dog", "cat", "newspaper", "hello", "water" };
            deutsch = new[] { "der hund", "die katze", "die zeitung", "hallo", "das wasser" };

            InitializeComponent();

            changeLanguage1.Text = changeLanguage1.Items[0].ToString();
            changeLanguage2.Text = changeLanguage1.Items[0].ToString();
        }
        private void translateWord()
        {
            int currentLanguage = changeLanguage1.SelectedIndex;

            string[] currentArray = currentLanguage switch
            {
                0 => russian,
                1 => english,
                2 => deutsch,
            };

            int selectedLanguage = changeLanguage2.SelectedIndex;

            string[] selectedArray = selectedLanguage switch
            {
                0 => russian,
                1 => english,
                2 => deutsch,
            };

            int count = 0;

            foreach (var word in currentArray)
            {
                if (word == textWrite.Text) textRead.Text = selectedArray[count];
                count++;
            }
        }
        private void swapLanguage_Click(object sender, EventArgs e)
        {
            if (changeLanguage1.Text == changeLanguage2.Text) MessageBox.Show("Выберите два разных языка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                (changeLanguage1.SelectedIndex, changeLanguage2.SelectedIndex) =
                    (changeLanguage2.SelectedIndex, changeLanguage1.SelectedIndex);
            }
        }

        private void cleanOut_Click(object sender, EventArgs e)
        {
            textWrite.Text = "";
            textRead.Text = "";
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            translateWord();
        }

        private void textWrite_TextChanged(object sender, EventArgs e)
        {
            translateWord();
        }
    }
}