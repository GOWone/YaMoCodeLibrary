using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaMoCodeLibrary.Models
{
    public class CommunityCollectModel
    {
        private string iconpath;

        public string IconPath
        {
            get { return iconpath; }
            set { iconpath = value; }
        }

        private string collectTiltle;

        public string CollectTitle
        {
            get { return collectTiltle; }
            set { collectTiltle = value; }
        }

        private string collecticonpath;

        public string CollectIconPath
        {
            get { return collecticonpath; }
            set { collecticonpath = value; }
        }
    }
}
