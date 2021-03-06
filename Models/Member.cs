using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RegisterFinalTest.Models
{
	public class Member
	{
		public int MemberId { get; set; }
		[Required]
		[Display(Name ="Họ")]
		public string FistName { get; set; }
		[Required]
		[Display(Name = "Tên")]
		public string LastName { get; set; }
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Display(Name = "Mật khẩu")]
		//[Required]
		[DataType("Password")]
		public string Password { get; set; }
		//[Display(Name ="Nhập lại mật khẩu")]
		//[DataType("Password")]
		//[Compare("Password")]
		//[NotMapped]
		//public string ConfirmPassword { get; set; }
	}
}