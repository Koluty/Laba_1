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

namespace Laba_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle, rand_rectangle;
            int x_1, x_2, y_1, y_2;
            try
            {
                x_1 = Convert.ToInt32(x1.Text);
                y_1 = Convert.ToInt32(y1.Text);
                x_2 = Convert.ToInt32(x2.Text);
                y_2 = Convert.ToInt32(y2.Text);
                rectangle = new Rectangle(x_1, y_1, x_2, y_2);  
                width.Content = rectangle.Width;
                height.Content = rectangle.Height;

                rand_rectangle = new Rectangle();
                rand_x1.Content = rand_rectangle.X_1;
                rand_y1.Content = rand_rectangle.Y_1;
                rand_x2.Content = rand_rectangle.X_2;
                rand_y2.Content = rand_rectangle.Y_2;
                rand_width.Content = rand_rectangle.Width;
                rand_height.Content = rand_rectangle.Height;
            }
            catch { MessageBox.Show("Помилка при введенні даних"); }
        }
    }
}
