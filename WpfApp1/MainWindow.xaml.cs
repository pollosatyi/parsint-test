using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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
using static System.Net.WebRequestMethods;

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

        private  void StrBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DateFrom.SelectedDate == null || DateTo.SelectedDate == null||string.IsNullOrEmpty(articleTb.Text))
            {
                Console.WriteLine("Не выбрали дату начала или окончания или номер статьи");
                return;
            }

            var dateFrom = (DateTime)DateFrom.SelectedDate;
            var dateTo = (DateTime)DateTo.SelectedDate;
            var article = articleTb.Text;

            //IWebDriver driver = new FirefoxDriver
            //{
            //    Url = @"https://bsr.sudrf.ru/bigs/portal.html"
            //};
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://bsr.sudrf.ru/bigs/portal.html");
        }
    }
    }

