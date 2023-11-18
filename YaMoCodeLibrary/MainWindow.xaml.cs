using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using YaMoCodeLibrary.Dialog;
using YaMoCodeLibrary.Models;
using YaMoCodeLibrary.Pages;
using DSPLibrary.Filters.Base64;
using DSPLibrary.Filters.Butterworth;
using DSPLibrary.Signals;

namespace YaMoCodeLibrary
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            InitCodeLibrary();
            CodeLibraryList.ItemsSource = CodeLibrary;
            testSignal();
        }

        public void testSignal()
        {
            float[] samples = new[] { 0.5f, 0.2f, -0.3f, 1.2f, 1.6f, -1.8f, 0.3f, -0.2f };
            var s = new DiscreteSignal(2000, samples).Repeat(25000);

            var butterlp = new DSPLibrary.Filters.Butterworth.LowPassFilter(0.12, 4);
            var b1utterlp = new DSPLibrary.Filters.Butterworth.HighPassFilter(0.12, 4);
            var b1utterbp = new DSPLibrary.Filters.ChebyshevI.BandPassFilter(0.12, 0.3, 10);

            var butterlpfilter = new IirFilter64(butterlp.Tf);
            var butterbpfilter = new IirFilter64(b1utterbp.Tf);

            var rip = b1utterbp.Ripple;

        }



        public event PropertyChangedEventHandler PropertyChanged;

        public List<CodeLibrary> CodeLibrary = new List<CodeLibrary>();

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void InitCodeLibrary()
        {
            CodeLibrary.Add(new CodeLibrary() { IconPath = "/Assets/icon/codelibrary.png", LibraryName = "C++代码库" });
            CodeLibrary.Add(new CodeLibrary() { IconPath = "/Assets/icon/codelibrary.png", LibraryName = "C#代码库" });
            CodeLibrary.Add(new CodeLibrary() { IconPath = "/Assets/icon/codelibrary.png", LibraryName = "Java代码库" });
            CodeLibrary.Add(new CodeLibrary() { IconPath = "/Assets/icon/codelibrary.png", LibraryName = "C代码库" });
        }

        private void btn_CloseWinEvent(object sender, MouseButtonEventArgs e)
        {
            
            this.Close();
        }

        //private void btn_MaxWinEvent(object sender, MouseButtonEventArgs e)
        //{
        //    if (this.WindowState == WindowState.Maximized)
        //    {
        //        this.WindowState = WindowState.Normal;
        //    }
        //    else
        //    {
        //        this.WindowState = WindowState.Maximized;
        //    }
        //}

        private void btn_MinWinEvent(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_WindowMoveEvent(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void btn_JumpToStartPage(object sender, MouseButtonEventArgs e)
        {
            StartPage startPage = new StartPage();
            if (startPage != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = startPage
                };
            }
        }

        private void btn_JumpToCollectPage(object sender, MouseButtonEventArgs e)
        {
            CollectPage collectPage = new CollectPage();
            if (collectPage != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = collectPage
                };
            }
        }

        public static LoginView loginView = null;
        private void btn_OpenUserManagement(object sender, MouseButtonEventArgs e)
        {
            if (loginView == null)
            {
                loginView = new LoginView();
                loginView.Show();
            }
            else
            {
                loginView.Activate();
                loginView.WindowState = WindowState.Normal;
            }

        }

        private void btn_JumpToViewMorePage(object sender, MouseButtonEventArgs e)
        {
            ViewMorePage viewMorePage = new ViewMorePage();
            if (viewMorePage != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = viewMorePage
                };
            }
        }

        private void btn_JumpToGetYMSoft(object sender, MouseButtonEventArgs e)
        {
            GetYMSoftwarePage getYmSoftPage = new GetYMSoftwarePage();
            if (getYmSoftPage != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = getYmSoftPage
                };
            }
        }

        private void btn_AddCodeBlockEvent(object sender, RoutedEventArgs e)
        {
            CodeBlockPage codeBlockPage = new CodeBlockPage();
            if (codeBlockPage != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = codeBlockPage
                };
            }
        }

        private void btn_OpenCodeLibrary(object sender, MouseButtonEventArgs e)
        {
            CodeLibraryPage codeLibrary = new CodeLibraryPage();
            if (codeLibrary != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = codeLibrary
                };
            }
        }

        private void btn_JumpToSetting(object sender, MouseButtonEventArgs e)
        {
            SettingPage settingPage = new SettingPage();
            if (settingPage != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = settingPage
                };
            }
        }

        public static FeedbackPage feedbackPage = null;
        private void btn_JumpToFeedBack(object sender, MouseButtonEventArgs e)
        {
            if (feedbackPage == null)
            {
                feedbackPage = new FeedbackPage();
                feedbackPage.Show();
            }
            else
            {
                feedbackPage.Activate();
                feedbackPage.WindowState = WindowState.Normal;
            }
        }

        private void btn_JumpToPaidSupport(object sender, MouseButtonEventArgs e)
        {
            PaidSupportPage paidSupportPage = new PaidSupportPage();
            if (paidSupportPage != null)
            {
                MainWindowPresenter.Content = new Frame()
                {
                    Content = paidSupportPage
                };
            }
        }
    }
}
