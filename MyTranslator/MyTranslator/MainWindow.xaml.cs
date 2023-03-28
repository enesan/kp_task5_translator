using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyTranslator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void TryingToTranslateTheWord()
        {
            if (SearchLanguage.SelectedIndex == TargetLanguage.SelectedIndex)
                OutputBox.Text = InputBox.Text;
            else
            {
                try
                {
                    OutputBox.Text = dict[Languages[TargetLanguage.SelectedIndex]][Array.IndexOf(dict[Languages[SearchLanguage.SelectedIndex]], InputBox.Text)];
                    OutputTranslationOptions.Text = TranslationOptions[dict[Languages[TargetLanguage.SelectedIndex]][Array.IndexOf(dict[Languages[SearchLanguage.SelectedIndex]], InputBox.Text)].ToString()];
                }
                catch
                {
                    OutputBox.Text = "";
                    OutputTranslationOptions.Text = "";
                }
            }
        }

        string[] Languages { get; set; }
        string[] Russia { get; set; }
        string[] English { get; set; }
        string[] Deutsch { get; set; }

        Dictionary<string, string[]> dict;

        Dictionary<string, string> TranslationOptions; //костыль, прикрученный после смены задания
        public MainWindow()
        {
            Languages = new string[] { "Russia", "English", "Deutsch" };
            Russia = new string[] { "Собака", "Кошка", "Газета", "Лимон", "Апельсин" };
            English = new string[] { "Dog", "Саt", "Newspaper", "Lemon", "Orange" };
            Deutsch = new string[] { "der Hund", "die Catze", "die Zeitung", "die Zitrone", "die Orange" };

            dict = new Dictionary<string, string[]>
            {
                { Languages[0], Russia },
                { Languages[1], English },
                { Languages[2], Deutsch }
            };

            TranslationOptions = new Dictionary<string, string>
            {
                {"Собака", "1. Пес\n2. Собачка\n3. Песик\n4. Псина"},
                {"Кошка", "1. Кошка\n2. Кот\n3. Котенок\n4. Котик"},
                {"Газета", "1. Редакция газеты\n2. Газетка\n3. Газетный"},
                {"Лимон", "1. Лимончик\n2. Лимоновый"},
                {"Апельсин", "1. Ораньжевый\n2. Ораньжевая краска"},
                {"Dog", "1. Hound\n2. Pooch"},
                {"Саt", "1. Tomcat\n2. Gib"},
                {"Newspaper", "1. Paper\n2. Gazette\n3. Journal"},
                {"Lemon", "1. Limon"},
                {"Orange", "*единственный вариант*"},
                {"der Hund", "1. Wasserhund"},
                {"die Catze", "1. Hinze\n2. Katze\n3. Kater"},
                {"die Zeitung", "1. Gazette\n2. Journal"},
                {"die Zitrone", "1. Limone\n2. Zitronenbaum"},
                {"die Orange", "1. Apfelsine\n2. Apfelsinenbaum"}
            };

            InitializeComponent();

            SearchLanguage.ItemsSource = Languages;
            SearchLanguage.Text = SearchLanguage.Items[0].ToString();

            TargetLanguage.ItemsSource = Languages;
            TargetLanguage.Text = TargetLanguage.Items[1].ToString();
        }

        private void SwitchLanguageButton_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Text = OutputBox.Text;
            (SearchLanguage.SelectedIndex, TargetLanguage.SelectedIndex) = (TargetLanguage.SelectedIndex, SearchLanguage.SelectedIndex);
        }

        private void InputBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TryingToTranslateTheWord();
        }

        private void TargetLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TryingToTranslateTheWord();
        }
    }
}
