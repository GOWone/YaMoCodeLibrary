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
using YaMoDevTools.ViewModels;

namespace YaMoCodeLibrary.Dialog
{
    /// <summary>
    /// LoginView.xaml 的交互逻辑
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
        private void WindowMove_LBDownEvent(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void btn_JumpToRegister(object sender, MouseButtonEventArgs e)
        {
            LoginOrRegister.Content = "注 册";
        }

        private void btn_OtherWayLogin(object sender, MouseButtonEventArgs e)
        {
            Msg_ErrorMsg.Text = "功能开发中...";
        }

        private void btn_CloseWindowEvent(object sender, RoutedEventArgs e)
        {
            MainWindow.loginView = null;
            this.Close();
        }
    }
}
