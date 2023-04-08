using ConfiguratorPC.AppDataFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using ConfiguratorPC.pages;

namespace ConfiguratorPC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            configuratorPCEntities.GetContext().computer.ToList();
            var processor = configuratorPCEntities.GetContext().processor.Count();
            var mother = configuratorPCEntities.GetContext().motherboard.Count();
            var body = configuratorPCEntities.GetContext().body.Count();
            var ram = configuratorPCEntities.GetContext().ram.Count();
            var videocard = configuratorPCEntities.GetContext().videocard.Count();
            var drive = configuratorPCEntities.GetContext().hard_drive.Count();
            var ssd = configuratorPCEntities.GetContext().ssd.Count();
            var add_ssd = configuratorPCEntities.GetContext().add_ssd.Count();
            var cooling = configuratorPCEntities.GetContext().cooling.Count();
            var power_unit = configuratorPCEntities.GetContext().power_unit.Count();


            processorTB.Text = "вариантов " + processor;
            //button1.Content = "ПРОЦЕССОР\n\nвариантов " + processor;
            //button2.Content = "МАТЕРИНСКАЯ ПЛАТА\n\nвариантов "+ mother;
            //button3.Content = "КОРПУС\n\nвариантов " + body;
            //button4.Content = "ОПЕРАТИВНАЯ ПАМЯТЬ\n\nвариантов " + ram;
            //button5.Content = "ВИДЕОКАРТА\n\nвариантов " + videocard;
            //button6.Content = "ЖЕСТКИЙ ДИСК\n\nвариантов " + drive;
            //button7.Content = "SSD\n\nвариантов " + ssd;
            //button8.Content = "Доп. SSD\n\nвариантов " + add_ssd;
            //button9.Content = "ОХЛАЖДЕНИЕ\n\nвариантов " + cooling;
            //button10.Content = "SSD\n\nвариантов " + power_unit;
        }

        
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void minimazeWin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void exitWin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        bool MainWindowState = false;
        private void expandWin_Click(object sender, RoutedEventArgs e)
        {
            if (!MainWindowState)
            {
                WindowState = (WindowState)FormWindowState.Maximized;
                MainWindowState = true;
            }
            else
            {
                WindowState = (WindowState)FormWindowState.Normal;
                MainWindowState = false;
            }
        }

        private void procBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageProcessors());
        }
    }
}
