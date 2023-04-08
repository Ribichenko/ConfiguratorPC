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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ConfiguratorPC
{
    /// <summary>
    /// Логика взаимодействия для regWin.xaml
    /// </summary>
    public partial class regWin : Window
    {
        public regWin()
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

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            //var us = configuratorPCEntities.GetContext().user.FirstOrDefault(x => x.mail == mailTB.Text && x.password == passTB.Text && x.name == nameTB.Text);
            if (mailTB.Text == "")
            {
                //mailTB.BorderThickness = Brush.TransformProperty.Name();
                mailTB.BorderBrush = Brushes.Red;
            }
            else
            {
                mailTB.BorderBrush = Brushes.Transparent;

                if (nameTB.Text == "")
                {
                    nameTB.BorderBrush = Brushes.Red;
                }
                else
                {
                    nameTB.BorderBrush = Brushes.Transparent;
                    if (passTB.Text == "")
                    {
                        passTB.BorderBrush = Brushes.Red;
                    }
                    else
                    {
                        passTB.BorderBrush = Brushes.Transparent;
                        if (pass2TB.Text == "")
                        {
                            pass2TB.BorderBrush = Brushes.Red;
                        }
                        else
                        {
                            if (passTB.Text != pass2TB.Text)
                            {
                                
                                pass2TB.Background = Brushes.Red;
                            }
                            else
                            {
                                
                                pass2TB.Background = Brushes.Green;

                                if (configuratorPCEntities.GetContext().user.Count(x => x.mail == mailTB.Text) > 0)
                                {
                                    MessageBox.Show("Эта почта уже зарегистрирована!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                    return;
                                }
                                else if (configuratorPCEntities.GetContext().user.Count(x => x.name == nameTB.Text) > 0)
                                {
                                    MessageBox.Show("Такое имя уже зарегистрировано!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                    return;
                                }
                                else
                                {
                                    try
                                    {
                                        user us = new user()
                                        {
                                            mail = mailTB.Text,
                                            name = nameTB.Text,
                                            password = passTB.Text,
                                            role_id = 0
                                        };
                                        configuratorPCEntities.GetContext().user.Add(us);
                                        configuratorPCEntities.GetContext().SaveChanges();
                                        MessageBox.Show("Добро пожаловать, " + nameTB.Text + "!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Ошибка при добавлении данных!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                    }
                                }
                            }
                            //pass2TB.BorderBrush = Brushes.Transparent;
                            //MainWindow MainWin = new MainWindow();
                            //this.Close();
                            //MainWin.Show();
                        }
                    }
                }
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дааа, неповезло :(", "Не фарт", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            loginWin logWin = new loginWin();
            this.Close();
            logWin.Show();
        }
    }
}
