using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Book
    {
		#region Attributes & Properties
		private string author;
		private string title;

		public string Author
		{
			get { return author; }
			set { author = value; }
		}

		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		#endregion

		#region Constructors
		public Book()
		{

		}

		public Book(string _title)
		{
			title = _title;
		}

        public Book(string _title, string _author)
        {
            title = _title;
			author = _author;
        }
        #endregion
    }
}
