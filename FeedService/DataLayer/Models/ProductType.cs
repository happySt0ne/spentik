using FeedService.DataLayer.Interfaces;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text.Json.Serialization;

namespace FeedService.DataLayer.Models
{
    public class ProductType : ITable {
		[JsonIgnore]
		public int Id { get; set; }
		public string Name { get; set; }

		[JsonIgnore]
		public virtual ICollection<Product>? Products { get; set; }
	}
}
