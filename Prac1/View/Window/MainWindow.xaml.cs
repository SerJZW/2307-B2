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
            Persons.ItemsSource = new List<Person>()
           {
             new Person{Id = 1, Name = "Andrey", Age = 33, Description = "dsadsadeww"},
             new Person{Id = 1, Name = "Andrey", Age = 33, Description = "dsadsadeww"},
             new Person{Id = 1, Name = "Andrey", Age = 33, Description = "dsadsadeww"},
             new Person{Id = 1, Name = "Andrey", Age = 33, Description = "dsadsadeww"},
             new Person{Id = 1, Name = "Andrey", Age = 33, Description = "dsadsadeww"},
             new Person{Id = 1, Name = "Andrey", Age = 33, Description = "dsadsadeww"},
             new Person{Id = 1, Name = "Andrey", Age = 33, Description = "dsadsadeww"},
             new Person{Id = 1, Name = "Andrey", Age = 33, Description = "dsadsadeww"},
             new Person{Id = 2, Name = "Sergey", Age = 22, Description = "dfsfsdf"}
           };
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            int scaler = 3;
            Btn1.FontFamily = new FontFamily("Arial");
            Btn1.FontSize = Btn1.FontSize += scaler;
            MessageBox.Show("Кнопка нажата");
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            //Btn2.Visibility = Visibility.Hidden;
            
            Btn2.Background = new SolidColorBrush(Colors.Yellow);
            if(TB1.Text == "")
            {
                
                MessageBox.Show("Error", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Btn2.FontFamily = new FontFamily("Arial");
                MessageBox.Show("Button Have Sumbols", "Succsess", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                Btn2.Content = TB1.Text;
            }
        }
    }
}