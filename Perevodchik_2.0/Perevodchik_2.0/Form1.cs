using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perevodchik_2._0
{
    public partial class Form1 : Form
    {
        string[] languages, russian, english, deutsch;
        
        public Form1()
        {
            languages = new[] { "russian", "english", "deutsch" };

            russian = new[] { "матрос", "вор", "рубашка", "лодка", "картошка" };
            english = new[] { "sailor", "thief", "shirt", "boat", "potato" };
            deutsch = new[] { "matrose", "dieb", "hemd", "boot", "kartoffel" };

            InitializeComponent();
            choiseLang1.Text = choiseLang1.Items[0].ToString();
            choiseLang2.Text = choiseLang2.Items[0].ToString();
        }

        void PerevodSlova()
        {
            int currentLang = choiseLang1.SelectedIndex;
            string[] currentArray = russian;

            switch (currentLang)
            {
                case 0:
                    currentArray = russian;
                    break;
                case 1:
                    currentArray = english;
                    break;
                case 2:
                    currentArray = deutsch;
                    break;
            }

            int newLang = choiseLang2.SelectedIndex;
            string[] newArray = russian;

            switch (newLang)
            {
                case 0:
                    newArray = russian;
                    break;
                case 1:
                    newArray = english;
                    break;
                case 2:
                    newArray = deutsch;
                    break;
            }

            int count = 0;
            foreach(var item in currentArray) 
            {
                if (item == PoleVvoda.Text) PoleVyvoda.Text = newArray[count]; 
                count++;
            }
        }

        private void swapLangButton_Click(object sender, EventArgs e)
        {
            if (choiseLang1.Text == choiseLang2.Text) MessageBox.Show("Ты выбрал два одинаковых языка. Менять нечего.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                (choiseLang1.SelectedIndex, choiseLang2.SelectedIndex) = (choiseLang2.SelectedIndex, choiseLang1.SelectedIndex);
            }
        }

        private void PoleVvoda_TextChanged_1(object sender, EventArgs e)
        {
            PerevodSlova();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            PoleVvoda.Text = "";
            PoleVyvoda.Text = "";
        }
                        
    }
}
