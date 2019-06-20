using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace SPExam19._06
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] array;
        static object locker = new object();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ArrayFill(object state)
        {
            ArraySize arraySize = new ArraySize();
            array = new int[arraySize.Size];
            lock (locker)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = i;
                }
            }
        }
        private void StartToFillArray_Click(object sender, RoutedEventArgs e)
        {
            Thread[] threads = new Thread[int.Parse(number.Text)];
            ArraySize arraySize = new ArraySize
            {
                Size = int.Parse(number.Text)
            };
            for (int i = 0; i <= arraySize.Size; i++)
            {
                threads[i] = new Thread(ArrayFill);
                threads[i].Start();
            }
        }

        private async void CreateEssense_Click(object sender, RoutedEventArgs e)
        {
            Check check = new Check();
            User user = new User()
            {
                Login = login.Text,
                Email = email.Text,
                MobileNumber = mobileNumber.Text,
                Password = password.Text,
                DoublePassword = doublePassword.Text
            };
            if (check.ValidationCheck(user))
            {
                using (var context = new EssenseContext())
                {
                    context.Users.Add(user);
                    await context.SaveChangesAsync();
                }
            }
            else
            {
                MessageBox.Show("Некоторые поля заполнены некорректно");
            }
        }
    }
}
