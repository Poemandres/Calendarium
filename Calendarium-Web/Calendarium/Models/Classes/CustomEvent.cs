using System;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MysqlProject.Models
{
public class CustomEvent
{

		private int ID {get; set;}
		private String? customEventNAME {get; set;}
		private DateTime customEventDATE {get; set;}
		private int customEventTYPE {get; set;}
		private int customEventCATEGORY {get; set;}
		private bool customEventHOLIDAY {get; set;}
		private int customEventIMPORTANCE {get; set;}
		private String customEventICON {get; set;}

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