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

namespace YaMoCodeLibrary.Pages
{
    /// <summary>
    /// StartPage.xaml 的交互逻辑
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
            InitViewEditedList();
            ViewEditedCodeList.ItemsSource = EditCodeList;
            ViewEditedCodeList.SelectedIndex = 0;
        }
        public List<ViewEditedCodeModel> EditCodeList = new List<ViewEditedCodeModel>();
        private void InitViewEditedList()
        {
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/11/23"});
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
            EditCodeList.Add(new ViewEditedCodeModel() { IconPath = "/Assets/icon/code.png", CodeTitle = "OOP", Author = "陈陈", Space = '/', CodeLibrary = "C++", EditTime = "2023/8/23" });
        }
    }
}
