using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegisterFinalTest.Models
{
	public class RegisterDbContext:DbContext
	{
		public RegisterDbContext() : base("MemberConnectionString")
		{
		}
		public virtual DbSet<Member> Members { get; set; }
	}
}