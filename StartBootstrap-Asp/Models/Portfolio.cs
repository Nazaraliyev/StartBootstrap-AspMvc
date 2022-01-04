using System.ComponentModel.DataAnnotations;

namespace StartBootstrap_Asp.Models
{
	public class Portfolio
	{
		[Key]
		public int Id { get; set; }


		[MaxLength(100)]
		public string ImgName { get; set; }



		[MaxLength(500)]
		public string ImgDescription { get; set; }

	}
}
