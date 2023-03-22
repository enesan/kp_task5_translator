namespace deepL
{
    public partial class Form1 : Form
    {
        string[] languages = { "russian", "english", "german" };
        string[] russian = { "Привет", "Пока", "Удачи" };
        string[] english = { "Hello", "Bye", "Good luck" };
        string[] german = { "Hallo", "Wiedersehen", "Glück" };
        public Form1()
        {

            InitializeComponent();
            for (int i = 0; i < languages.Length; i++)
            {
                comboBox1.Items.Add(languages[i]);
                comboBox2.Items.Add(languages[i]);
            }
            comboBox1.SelectedItem = languages[0];
            comboBox2.SelectedItem = languages[1];
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string language1 = comboBox1.SelectedItem.ToString();
            string language2 = comboBox2.SelectedItem.ToString();
            textBox2.Text = translate(textBox1.Text, language1, language2);
        }
        public string translate(string text, string language, string language_2)
        {
            
            int index_word = 100;
            string translate = "Не удалось перевести слово";
            switch (language)
            {
                case "russian":
                    for (int i = 0; i < russian.Length;i++)
                    { 
                        if (russian[i] == text)
                        {
                            index_word = i;
                            break;
                        }
                    }
                    break;
                case "english":
                    for (int i = 0; i < english.Length; i++)
                    {
                        if (english[i] == text)
                        {
                            index_word = i;
                            break;
                        }
                    }
                    break;
                case "german":
                    for (int i = 0; i < german.Length; i++)
                    {
                        if (german[i] == text)
                        {
                            index_word = i;
                            break;
                        }
                    }
                    break;
            }
            if (index_word != 100)
            {
                switch (language_2)
                {
                    case "russian":
                        translate = russian[index_word];
                        break;
                    case "english":
                        translate = english[index_word];
                        break;
                    case "german":
                        translate = german[index_word];
                        break;
                }
            }
            return translate;
        }
    }
}