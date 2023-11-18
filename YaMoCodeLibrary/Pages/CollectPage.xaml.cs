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
    /// CollectPage.xaml 的交互逻辑
    /// </summary>
    public partial class CollectPage : Page
    {
        public CollectPage()
        {
            InitializeComponent();
            InitLocalCollectList();
            InitCommunityLocalCollectList();
            localCollectList.ItemsSource = localCollectListArr;
            communityCollectList.ItemsSource = communityCollectListArr;
        }
        public List<LocalCollectModel> localCollectListArr = new List<LocalCollectModel>();
        private void InitLocalCollectList()
        {
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png"});
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            localCollectListArr.Add(new LocalCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
        }

        public List<CommunityCollectModel> communityCollectListArr = new List<CommunityCollectModel>();
        private void InitCommunityLocalCollectList()
        {
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
            communityCollectListArr.Add(new CommunityCollectModel() {IconPath = "/Assets/icon/code.png", CollectTitle = "OOP", CollectIconPath = "/Assets/icon/collected.png" });
        }

        private void btn_Test(object sender, MouseButtonEventArgs e)
        {
            CodeBlockPage codeBlockPage = new CodeBlockPage();
            if(codeBlockPage != null)
            {
                CollectedCodePresenter.Content = new Frame
                {
                    Content = codeBlockPage
                };
            }
        }
    }
}
