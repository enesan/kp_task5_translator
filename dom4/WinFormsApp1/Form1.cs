using System.Text.Json.Nodes;
using System;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int curTransPoss = 0;
        string from = "ru";
        string to = "en";
        List<string> translators = new List<string>();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Русский");
            comboBox1.Items.Add("Английский");
            comboBox1.Items.Add("Немецкий");
            comboBox1.Items.Add("Китайский");
            comboBox1.Items.Add("Итальянский");
            comboBox2.Items.Add("Русский");
            comboBox2.Items.Add("Английский");
            comboBox2.Items.Add("Немецкий");
            comboBox2.Items.Add("Китайский");
            comboBox2.Items.Add("Итальянский");
            comboBox1.SelectedText = "Русский";
            comboBox2.SelectedText = "Английский";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            from = fullLangToShort(comboBox1.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            to = fullLangToShort(comboBox2.SelectedItem.ToString());
        }

        private string fullLangToShort(string lang)
        {
            switch (lang)
            {
                case "Русский":
                    return "ru";
                case "Английский":
                    return "en";
                case "Немецкий":
                    return "de";
                case "Китайский":
                    return "zh";
                case "Итальянский":
                    return "it";
            }
            return "ru";
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                string req = string.Format("https://api.mymemory.translated.net/get?q={0}&langpair={1}|{2}",
                    richTextBox1.Text,
                    from,
                    to);
                var uri = new Uri(req);
                Stream respStream = await client.GetStreamAsync(uri);
                var resp = JsonSerializer.Deserialize<Responce>(respStream);
                curTransPoss = 0;
                translators = new List<string>();
                foreach (ResponceMatches match in resp.matches)
                {
                    translators.Add(match.translation);
                }
                richTextBox2.Text = translators[curTransPoss];
            }
            catch
            {
                richTextBox2.Text = "Произошли технические шоколадки, всем оставаться на своих местах";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            curTransPoss--;
            if (curTransPoss < 0 && translators.Count != 0)
            {
                curTransPoss = translators.Count - 1;
            }
            else if (curTransPoss < 0)
            {
                curTransPoss = 0;
            }
            richTextBox2.Text = translators[curTransPoss];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            curTransPoss++;
            if (curTransPoss >= translators.Count)
            {
                curTransPoss = 0;
            }
            richTextBox2.Text = translators[curTransPoss];
        }
    }

    public class Responce
    {
        public ResponceMatches[]? matches { get; set; }
    }

    public class ResponceMatches
    {
        public string? translation { get; set; }
    }
}