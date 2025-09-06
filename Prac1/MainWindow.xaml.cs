using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prac1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Список элементов для вывода в ListBox или ListView
            Book.ItemsSource = new List<Books>()
            {
                new Books{id = 1, title = "Книга 1"},
                new Books{id = 2, title = "Книга 2"}
            };
        }

        //Метод уведомление о нажатии
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы нажали кнопку");
            //if(TB1.Text == "")
            //{
            //    MessageBox.Show("Error");
            //}
        }
        //Метод закрывающий приложение
        private void ExitBtnClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}