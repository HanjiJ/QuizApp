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

namespace QuizApp
{
    public partial class MainWindow : Window
    {
        private int score = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            // Инициализировать элементы управления RadioButton
            RadioButton q1_1 = (RadioButton)FindName("q1_1");
            RadioButton q2_1 = (RadioButton)FindName("q2_1");
            RadioButton q3_4 = (RadioButton)FindName("q3_4");
            RadioButton q4_1 = (RadioButton)FindName("q4_1");
            RadioButton q5_1 = (RadioButton)FindName("q5_1");
            RadioButton q6_1 = (RadioButton)FindName("q6_1");
            RadioButton q7_4 = (RadioButton)FindName("q7_4");
            RadioButton q8_1 = (RadioButton)FindName("q8_1");
            RadioButton q9_1 = (RadioButton)FindName("q9_1");
            RadioButton q10_1 = (RadioButton)FindName("q10_1");

            // Проверить ответы
            if (q1_1.IsChecked == true) score++;
            if (q2_1.IsChecked == true) score++;
            if (q3_4.IsChecked == true) score++;
            if (q4_1.IsChecked == true) score++;
            if (q5_1.IsChecked == true) score++;
            if (q6_1.IsChecked == true) score++;
            if (q7_4.IsChecked == true) score++;
            if (q8_1.IsChecked == true) score++;
            if (q9_1.IsChecked == true) score++;
            if (q10_1.IsChecked == true) score++;

            // Отобразить результаты
            string message;
            if (score >= 8) message = "Отлично! " + score + "/10";
            else if (score >= 6) message = "Хорошо! " + score + "/10";
            else if (score >= 4) message = "Удовлетворительно! " + score + "/10";
            else message = "Плохо! Попробуйте еще раз! " + score + "/10";

            MessageBox.Show(message);
        }

    }
}


