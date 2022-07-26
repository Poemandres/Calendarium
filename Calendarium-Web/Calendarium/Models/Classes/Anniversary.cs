using System;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MysqlProject.Models
{
	public class Anniversary
	{

		public int anniversaryID { get; set; }
		public String? anniversaryNAME { get; set; }
		public DateTime anniversaryDATE { get; set; }
		public int anniversarySTARTYEAR { get; set; }
		public int anniversaryTYPE { get; set; }
		public bool anniversaryHOLIDAY { get; set; }
		public int anniversaryIMPORTANCE { get; set; }
		public String? anniversaryICON { get; set; }

		public Anniversary(int anniversaryID, String anniversaryNAME, DateTime anniversaryDATE, int anniversarySTARTYEAR, int anniversaryTYPE, bool anniversaryHOLIDAY,
			int anniversaryIMPORTANCE, String anniversaryICON)
		{
			this.anniversaryID = anniversaryID;
			this.anniversaryNAME = anniversaryNAME;
			this.anniversaryDATE = anniversaryDATE;
			this.anniversarySTARTYEAR = anniversarySTARTYEAR;
			this.anniversaryTYPE = anniversaryTYPE;
			this.anniversaryHOLIDAY = anniversaryHOLIDAY;
			this.anniversaryIMPORTANCE = anniversaryIMPORTANCE;
			this.anniversaryICON = anniversaryICON;
		}

	}
	public class AnniversaryContext : DbContext
	{
		public DbSet<Anniversary> dbanniversaries { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
		{
			optionBuilder.UseMySQL("server=localhost;database=calendarium;user=root;password=");
		}
	}
}