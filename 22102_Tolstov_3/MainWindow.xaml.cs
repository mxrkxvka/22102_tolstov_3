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

namespace _22102_Tolstov_3
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void tboxArray_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(tboxArray.Text);

            try
            {
                int start = int.Parse(tboxStart.Text);
                int end = int.Parse(tboxEnd.Text);

                if (start >= end) throw new Exception("неверно определен диапазон");
                if (n <= 0) throw new Exception("массив не может быть размеров <= 0");
                if (tboxStart.Text == "" || tboxStart.Text == "" || tboxEnd.Text == "") throw new Exception("поля не могут быть пустыми");

                Random rnd = new Random();
                int[] array = new int[n];

                for (int i = 0; i < n; i++)
                {
                    array[i] = rnd.Next(start, end + 1);
                }

                array = array.OrderBy(x => x % 2 != 0).ToArray();

                lblResult.Content = "Результат:\n";
                lblResult.Content += String.Join(" ", array);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        private void tboxEnd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tboxStart_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tboxArraySize_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
