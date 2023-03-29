using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        string[] languages { get; set; }
        string[] rus, eng, deu;

        private void swch_b_Click(object sender, RoutedEventArgs e)
        {
            (src_lan.Text, trgt_lan.Text) = (trgt_lan.Text, src_lan.Text);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Dictionary<int, string[]> dict = new Dictionary<int, string[]>
            {
                { 0, rus},
                { 1, eng},
                { 2, deu}
            };

            int curSrc = src_lan.SelectedIndex, curTrgt = trgt_lan.SelectedIndex;

            try { TextBlock.Text = dict[curTrgt][Array.IndexOf(dict[curSrc], TextBox.Text)]; }
            catch { TextBlock.Text = ""; }
        }

            public MainWindow()
        {
            languages = new string[] { "Russian", "English", "Deutch" };
            rus = new string[] { "кошка", "собака", "газета", "лимон", "апельсин" };
            eng = new string[] { "cat", "dog", "paper", "lemon", "orange" };
            deu = new string[] { "die Katze", "der Hund", "dieZeitung", "die Zitrone", "die Orange" };

            InitializeComponent();

            src_lan.ItemsSource = languages;
            trgt_lan.ItemsSource = languages;

            src_lan.Text = languages[0];
            trgt_lan.Text = languages[1];
        }

    }
}
