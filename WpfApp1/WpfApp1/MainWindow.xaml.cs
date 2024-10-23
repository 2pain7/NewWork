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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Пожалуйста, введите ваше имя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (prov(name))
                {
                    MessageBox.Show("Пожалуйста, используйте латиницу.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else 
                {
                    if (char.IsUpper(name[0]))
                    {
                        MessageBox.Show($"Вы ввели имя: {name}", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else 
                    {
                        MessageBox.Show("Пожалуйста, начните с заглавной буквы.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }
        private bool prov (string text)
        {
            if (text.Any(wordByte => wordByte > 127))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
