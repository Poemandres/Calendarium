using System;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MysqlProject.Models
{
	public class User
	{


		public int ID { get; set; }
		public String? userEMAIL { get; set; }
		public String? userNAME { get; set; }
		public String? userPASSWORD { get; set; }
		public String? userLANGUAGE { get; set; }

		public User(int ID, String userEMAIL, String userNAME, String userPASSWORD, String userLANGUAGE)
		{
			this.ID = ID;
			this.userEMAIL = userEMAIL;
			this.userNAME = userNAME;
			this.userPASSWORD = userPASSWORD;
			this.userLANGUAGE = userLANGUAGE;
		}


	}
	public class UserContext : DbContext
	{
		public DbSet<User> user { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
		{
			optionBuilder.UseMySQL("server=localhost;database=calendarium;user=root;password=");
		}

	}
}