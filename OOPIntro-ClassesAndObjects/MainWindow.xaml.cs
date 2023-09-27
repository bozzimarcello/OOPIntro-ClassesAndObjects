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

namespace OOPIntro_ClassesAndObjects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CollezioneVideo unaCollezioneVideo;

        public MainWindow()
        {
            InitializeComponent();

            unaCollezioneVideo = new CollezioneVideo();

            DgrElenco.ItemsSource = unaCollezioneVideo.LeggiTutte();
        }

        private void BtnCaricaFile_Click(object sender, RoutedEventArgs e)
        {
            unaCollezioneVideo.LeggiDaFile();
            DgrElenco.Items.Refresh();
        }
    }
}
