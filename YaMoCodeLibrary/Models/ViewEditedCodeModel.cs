using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaMoCodeLibrary.Models
{
    public class ViewEditedCodeModel
    {
		private string iconpath;

		public string IconPath
		{
			get { return iconpath; }
			set { iconpath = value; }
		}


		private string codetitle;

		public string CodeTitle
		{
			get { return codetitle; }
			set { codetitle = value; }
		}

		private string author;

		public string Author
		{
			get { return author; }
			set { author = value; }
		}

		private char space;

		public char Space
		{
			get { return space; }
			set { space = value; }
		}


		private string codelibrary;

		public string CodeLibrary
		{	
			get { return codelibrary; }
			set { codelibrary = value; }
		}

		private string edittime;

		public string EditTime
		{
			get { return edittime; }
			set { edittime = value; }
		}
	}
}
