using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegisterFinalTest.ViewModels
{/// <summary>
/// use ViewModel để xử lý ConfirmPassword
/// làm bình thường chỉ thêm class bên dưới và sửa lại view sử dụng View Model thay model mặc định
/// hoàn toàn không liên quan đến dữ liệu db cũng chính là model gốc
/// </summary>
	public class RegisterViewModel
	{
		public int MemberId { get; set; }
		[Required]
		[Display(Name = "Họ")]
		public string FistName { get; set; }
		[Required]
		[Display(Name = "Tên")]
		public string LastName { get; set; }
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Display(Name = "Mật khẩu")]
		[Required]
		[DataType("Password")]
		public string Password { get; set; }
		[Display(Name = "Nhập lại mật khẩu")]
		[DataType("Password")]
		[Compare("Password")]
		public string ConfirmPassword { get; set; }
	}
}