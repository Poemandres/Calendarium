using System;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MysqlProject.Models
{
	public class Anniversary
{

	private int anniversaryID { get; set; }
	private String? anniversaryNAME { get; set; }
	private DateTime anniversaryDATE { get; set; }
	private int anniversarySTARTYEAR { get; set; }
	private int anniversaryTYPE { get; set; }
	private bool anniversaryHOLIDAY { get; set; }
	private int anniversaryIMPORTANCE { get; set; }
	private String? anniversaryICON { get; set; }

	public Anniversary(int anniversaryID, String anniversaryNAME, DateTime anniversaryDATE, int anniversarySTARTYEAR, int anniversaryTYPE, bool anniversaryHOLIDAY, 
		int anniversaryIMPORTANCE, String anniversaryICON) { 
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
        public DbSet<Anniversary> db-anniversaries { get; set; }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;database=calendarium;user=root;password=");
        }
    }