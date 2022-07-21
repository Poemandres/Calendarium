using System;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MysqlProject.Models
{
	public class User
	{


		private int ID { get; set; }
		private String? userEMAIL { get; set; }
		private String? userNAME { get; set; }
		private String? userPASSWORD { get; set; }
		private String? userLANGUAGE { get; set; }

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
		public DbSet<User> dbusers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
		{
			optionBuilder.UseMySQL("server=localhost;database=calendarium;user=root;password=");
		}

	}
}