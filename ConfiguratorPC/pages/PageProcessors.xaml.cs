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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace ConfiguratorPC.pages
{
    /// <summary>
    /// Логика взаимодействия для PageProcessors.xaml
    /// </summary>
    public partial class PageProcessors : Page
    {
        public PageProcessors()
        {
            InitializeComponent();
            var currentProcessor = configuratorPCEntities.GetContext().processor.ToList();
            
            LV.ItemsSource = currentProcessor;
            
        }

        private void LV_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Hidden)
            {
                configuratorPCEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                LV.ItemsSource = configuratorPCEntities.GetContext().processor.ToList();
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
