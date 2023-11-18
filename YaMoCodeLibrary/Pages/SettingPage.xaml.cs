using System;
using System.Collections.Generic;
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
using YaMoCodeLibrary.Models;

namespace YaMoCodeLibrary.Pages
{
    /// <summary>
    /// SettingPage.xaml 的交互逻辑
    /// </summary>
    public partial class SettingPage : Page, INotifyPropertyChanged
    {
        public SettingPage()
        {
            InitializeComponent();
            InitSysSetting();
            SysSettingList.ItemsSource = SysSettingSource;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public List<SettingModel> SysSettingSource = new List<SettingModel>();

        private void InitSysSetting()
        {
            SysSettingSource.Add(new SettingModel() { IconPath = "/Assets/icon/setting_theme.png", SettingName = "软件主题" });
            SysSettingSource.Add(new SettingModel() { IconPath = "/Assets/icon/setting_storage.png", SettingName = "存储管理" });
            SysSettingSource.Add(new SettingModel() { IconPath = "/Assets/icon/setting_shortcutkey.png", SettingName = "快捷键设置" });
            SysSettingSource.Add(new SettingModel() { IconPath = "/Assets/icon/setting_helper.png", SettingName = "使用说明" });
            SysSettingSource.Add(new SettingModel() { IconPath = "/Assets/icon/setting_log.png", SettingName = "系统日志与异常" });
        }


        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
