using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kp_task6
{
    public partial class Form1 : Form
    {
        string[] languages, russian, english, deutsch;
        
        public Form1()
        {
            languages = new[] { "russian", "english", "deutsch" };

            russian = new[] { "яблоко", "мама", "тарелка", "пельмень" };
            english = new[] { "apple", "mother", "plate", "dumpling" };
            deutsch = new[] { "apfel", "mama", "teller", "teigtasche" };

            InitializeComponent();
            choose1.Text = choose1.Items[0].ToString();
            choose2.Text = choose2.Items[0].ToString();
        }

        void Translator()
        {
            int currentLang = choose1.SelectedIndex;
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

            int newLang = choose2.SelectedIndex;
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
                if (item == input.Text) output.Text = newArray[count]; 
                count++;
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            Translator();
        }

        private void swap_Click(object sender, EventArgs e)
        {
            (choose1.SelectedIndex, choose2.SelectedIndex) = (choose2.SelectedIndex, choose1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
