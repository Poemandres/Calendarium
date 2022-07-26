using System;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MysqlProject.Models
{
public class CustomEvent
{

		public int ID {get; set;}
		public String? customEventNAME {get; set;}
		public DateTime customEventDATE {get; set;}
		public int customEventTYPE {get; set;}
		public int customEventCATEGORY {get; set;}
		public bool customEventHOLIDAY {get; set;}
		public int customEventIMPORTANCE {get; set;}
		public String customEventICON {get; set;}

	public CustomEvent(int ID, String customEventNAME, DateTime customEventDATE, int customEventTYPE, int customEventCATEGORY, bool customEventHOLIDAY, 
		int customEventIMPORTANCE, String customEventICON) {
		this.ID = ID;
		this.customEventNAME = customEventNAME;
		this.customEventDATE = customEventDATE;
		this.customEventTYPE = customEventTYPE;
		this.customEventCATEGORY = customEventCATEGORY;
		this.customEventHOLIDAY = customEventHOLIDAY;
		this.customEventIMPORTANCE = customEventIMPORTANCE;
		this.customEventICON = customEventICON;
	}

}
	public class CustomEventContext : DbContext
    {
        public DbSet<CustomEvent> dbcustomevents { get; set; }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;database=calendarium;user=root;password=");
        }


}}