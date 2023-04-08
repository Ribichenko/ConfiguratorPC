using ConfiguratorPC.AppDataFile;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace ConfiguratorPC
{
    /// <summary>
    /// Логика взаимодействия для loginWin.xaml
    /// </summary>
    public partial class loginWin : Window
    {
        public loginWin()
        {
            InitializeComponent();
            configuratorPCEntities.GetContext().user.ToList();
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

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            if (mailTB.Text == "")
            {
                //mailTB.BorderThickness = Brush.TransformProperty.Name();
                mailTB.BorderBrush = Brushes.Red;
            }
            else
            {
                mailTB.BorderBrush = Brushes.Transparent;
                if (passTB.Text == "")
                {
                    passTB.BorderBrush = Brushes.Red;
                }
                else
                {
                    passTB.BorderBrush = Brushes.Transparent;
                    try
                    {
                        var us = configuratorPCEntities.GetContext().user.FirstOrDefault(x => x.mail == mailTB.Text && x.password == passTB.Text);
                        if (us == null)
                        {
                            MessageBox.Show("Почта или пароль неверен!", "Ошибка при авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            MainWindow MainWin = new MainWindow();
                            switch (us.role_id)
                            {

                                case 0:
                                    MessageBox.Show("Здравствуйте, Пользователь " + us.name + "!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                                    
                                    this.Close();
                                    MainWin.Show();
                                    break;
                                case 1:
                                    MessageBox.Show("Здравствуйте, Администратор " + us.name + "!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                                    this.Close();
                                    MainWin.Show();
                                    break;
                                default:
                                    MessageBox.Show("Данные не обнаружены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                    break;

                            }
                            //passTB.BorderBrush = Brushes.Transparent;
                            //MainWindow MainWin = new MainWindow();
                            //this.Close();
                            //MainWin.Show();
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая работа приложения!", "Ошибка" ,MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            regWin regWin = new regWin();
            this.Close();
            regWin.Show();
        }

        private void Hyperlink_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дааа, неповезло :(", "Не фарт", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
