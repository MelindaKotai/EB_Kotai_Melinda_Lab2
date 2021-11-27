using LibraryModel_Kotai_Melinda_Lab6.Models;
using System.Collections.Generic;

namespace Kotai_Melinda_Lab2.Models.LibraryViewModels
{
	public class PublisherIndexData
	{
		public IEnumerable<Publisher> Publishers { get; set; }
		public IEnumerable<Book> Books { get; set; }
		public IEnumerable<Order> Orders { get; set; }
	}
}
