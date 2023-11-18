using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace YaMoCodeLibrary.Models
{
    public class SettingModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string iconPath;
        /// <summary>
        /// 图标路径
        /// </summary>
        public string IconPath
        {
            get { return iconPath; }
            set
            {
                iconPath = value;
                //OnPropertyChanged();
            }
        }

        private string settingName;
        /// <summary>
        /// 功能标题
        /// </summary>
        public string SettingName
        {
            get { return settingName; }
            set
            {
                settingName = value;
                //OnPropertyChanged();
            }
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
