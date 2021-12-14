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


namespace spravochnik
{
    public struct spisok
    {
        public string name;
        public string phone;
    }
    
    public partial class MainWindow : Window
    {
        List<spisok> spisoks = new List<spisok>();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((tb1.Text == "") ||(tb2.Text == ""))
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                spisok a;
                a.name = tb1.Text;
                a.phone = tb2.Text;
                int x = find(a.name);
                if (x == -1)
                {
                    spisoks.Add(a);
                    tb1.Text = "";
                    tb2.Text = "";
                }
            
            else
            {
                    MessageBox.Show("Такой контакт существует");
            }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = tb1.Text;
            int x = find(s);
            if (x != -1)
            {
                tb2.Text = spisoks[x].phone;
            }
            else
            {
                MessageBox.Show("Контакт не найден");
            }
        }

        int find(string s)
        {
            for (int i = 0; i < spisoks.Count; i++)
            {
                if (spisoks[i].name.Equals(s))
                    return i;
            }
            return -1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
                for (int i = 0; i < spisoks.Count; i++)
                {
                    tb3.Text = spisoks[i].ToString();
                }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if ((tb1.Text == "") || (tb2.Text == ""))
            {
                MessageBox.Show("Заполните ФИО для удаления контакта");
            }
            else
            {
                string s = tb1.Text;
                int x = find(s);
                spisoks.RemoveAt(x);
                tb1.Text = "";
                MessageBox.Show("Контакт удален");
            }
        }

        
    }
}
