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
using YaMoCodeLibrary.Models;
using YaMoDevTools.ViewModels;

namespace YaMoCodeLibrary.Pages
{
    /// <summary>
    /// CodeLibraryPage.xaml 的交互逻辑
    /// </summary>
    public partial class CodeLibraryPage : Page
    {
        public CodeLibraryPage()
        {
            InitializeComponent();
            InitLibCodeBlockList();
            
            LibCodeBlockList.ItemsSource = LibCodeBlockArr;
        }

        public List<LibCodeBlockModel> LibCodeBlockArr = new List<LibCodeBlockModel>();
        private void InitLibCodeBlockList()
        {
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            LibCodeBlockArr.Add(new LibCodeBlockModel() { IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
        }

        private void btn_OpenCodeBlockEvent(object sender, MouseButtonEventArgs e)
        {
            CodeBlockPage codeBlockPage = new CodeBlockPage();
            if (codeBlockPage != null)
            {
                LibraryCodeBlockPresenter.Content = new Frame
                {
                    Content = codeBlockPage
                };
            }
        }
    }
}
