using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_wpf_konyvek
{
    public class Book
    {
		private string _title;

		public string title
		{
			get { return _title; }
			set { _title = value; }
		}

		private int _pageCount;

		public int pageCount
		{
			get { return _pageCount; }
			set { _pageCount = value; }
		}

		private string _author;

		public string author
		{
			get { return _author; }
			set { _author = value; }
		}

		private string _type;

		public string type
		{
			get { return _type; }
			set { _type = value; }
		}

        public Book(string row)
        {
			string[] datas = row.Split(';');
			title = datas[0];
			pageCount = int.Parse(datas[1]);
			author = datas[2];
			type = datas[3];
        }
    }
}
