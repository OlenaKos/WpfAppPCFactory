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

namespace WpfAppPCFactory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PCConfigurator pCConfigurator;
        PC pc;
        public MainWindow()
        {
            InitializeComponent();

            pCConfigurator = new PCConfigurator();
            IPCFactory factory = new HomePCFactory();
            PC pc = pCConfigurator.CreatePC(factory);

        }

        private void ButtonHomePC_Click(object sender, RoutedEventArgs e)
        {
            IPCFactory factory = new HomePCFactory();
            PC pc = pCConfigurator.CreatePC(factory);
            txtPCConfiguration.Text = GenerateText(pc);
        }

        private string GenerateText(PC pc)
        {
            return pc.box.Name + "\n" + pc.mainBoard.Name + "\n" + pc.memory.Name + "\n" + pc.processor.Name + "\n" + pc.sdd.Name;
        }

        private void ButtonGamePC_Click(object sender, RoutedEventArgs e)
        {
            IPCFactory factory = new GamePCFactory();
            PC pc = pCConfigurator.CreatePC(factory);
            txtPCConfiguration.Text = GenerateText(pc);
        }

        private void ButtonWorkPC_Click(object sender, RoutedEventArgs e)
        {
            IPCFactory factory = new OfficePCFactory();
            PC pc = pCConfigurator.CreatePC(factory);
            txtPCConfiguration.Text = GenerateText(pc);
        }
    }
}
