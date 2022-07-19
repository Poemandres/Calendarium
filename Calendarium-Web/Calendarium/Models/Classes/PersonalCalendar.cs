using System;

public class PersonalCalendar
{

		private int personalCalendarID {get; set;}
		private String? personalCalendarNAME {get; set;}
		private int personalCalendarCATEGORY {get; set;}
		private String? personalCalendarGROUP {get; set;}
		private String? personalCalendarURL {get; set;}
		private bool personalCalendarFIRST_DAY {get; set;}
		private DateTime personalCalendarNEW_YEAR {get; set;}
		private int personalCalendarBASE_STRUCTURE {get; set; }
		private String? personalCalendarDAY_NAME1 { get; set; }
		private String? personalCalendarDAY_NAME2 { get; set; }
		private String? personalCalendarDAY_NAME3 { get; set; }
		private String? personalCalendarDAY_NAME4 { get; set; }
		private String? personalCalendarDAY_NAME5 { get; set; }
		private String? personalCalendarDAY_NAME6 { get; set; }
		private String? personalCalendarDAY_NAME7 { get; set; }
		private String? personalCalendarDAY_NAME8 { get; set; }
		private String? personalCalendarDAY_NAME9 { get; set; }
		private String? personalCalendarDAY_NAME10 { get; set; }
		private String? personalCalendarDAY_NAME11 { get; set; }
		private String? personalCalendarDAY_NAME12 { get; set; }
		private String? personalCalendarMONTH_NAME1 {get; set;}
		private String? personalCalendarMONTH_NAME2 {get; set;}
		private String? personalCalendarMONTH_NAME3 {get; set;}
		private String? personalCalendarMONTH_NAME4 {get; set;}
		private String? personalCalendarMONTH_NAME5 {get; set;}
		private String? personalCalendarMONTH_NAME6 {get; set;}
		private String? personalCalendarMONTH_NAME7 {get; set;}
		private String? personalCalendarMONTH_NAME8 {get; set;}
		private String? personalCalendarMONTH_NAME9 {get; set;}
		private String? personalCalendarMONTH_NAME10 {get; set;}
		private String? personalCalendarMONTH_NAME11 {get; set;}
		private String? personalCalendarMONTH_NAME12 {get; set;}
		private String? personalCalendarMONTH_NAME13 { get; set; }
		private String? personalCalendarMONTH_NAME14 { get; set; }
		private String? personalCalendarMONTH_NAME15 { get; set; }
		private String? personalCalendarMONTH_NAME16 { get; set; }
		private String? personalCalendarMONTH_NAME17 { get; set; }
		private String? personalCalendarMONTH_NAME18 { get; set; }
		private String? personalCalendarMONTH_NAME19 { get; set; }
		private String? personalCalendarMONTH_NAME20 { get; set; }

	public PersonalCalendar(int personalCalendarID, String personalCalendarNAME, int personalCalendarCATEGORY, String personalCalendarGROUP, String personalCalendarURL,
		bool personalCalendarFIRST_DAY, int personalCalendarNEW_YEAR, int personalCalendarBASE_STRUCTURE,
		String personalCalendarDAY_NAME1, String personalCalendarDAY_NAME2, String personalCalendarDAY_NAME3, String personalCalendarDAY_NAME4, String personalCalendarDAY_NAME5, String personalCalendarDAY_NAME6,
		String personalCalendarDAY_NAME7, String personalCalendarDAY_NAME8, String personalCalendarDAY_NAME9, String personalCalendarDAY_NAME10,String personalCalendarDAY_NAME11,String personalCalendarDAY_NAME12,
		String personalCalendarMONTH_NAME1, String personalCalendarMONTH_NAME2, String personalCalendarMONTH_NAME3, String personalCalendarMONTH_NAME4, String personalCalendarMONTH_NAME5,
		String personalCalendarMONTH_NAME6, String personalCalendarMONTH_NAME7, String personalCalendarMONTH_NAME8, String personalCalendarMONTH_NAME9, String personalCalendarMONTH_NAME10,
		String personalCalendarMONTH_NAME11, String personalCalendarMONTH_NAME12, String personalCalendarMONTH_NAME13, String personalCalendarMONTH_NAME14, String personalCalendarMONTH_NAME15,
		String personalCalendarMONTH_NAME16, String personalCalendarMONTH_NAME17, String personalCalendarMONTH_NAME18, String personalCalendarMONTH_NAME19, String personalCalendarMONTH_NAME20){
		this.personalCalendarID = personalCalendarID;
		this.personalCalendarNAME = personalCalendarNAME;
		this.personalCalendarCATEGORY = personalCalendarCATEGORY;
		this.personalCalendarGROUP = personalCalendarGROUP;
		this.personalCalendarURL = personalCalendarURL;
		this.personalCalendarFIRST_DAY = personalCalendarFIRST_DAY;
		this.personalCalendarNEW_YEAR = personalCalendarNEW_YEAR;
		this.personalCalendarBASE_STRUCTURE = personalCalendarBASE_STRUCTURE;
		this.personalCalendarDAY_NAME1 = personalCalendarDAY_NAME1;
		this.personalCalendarDAY_NAME2 = personalCalendarDAY_NAME2;
		this.personalCalendarDAY_NAME3 = personalCalendarDAY_NAME3;
		this.personalCalendarDAY_NAME4 = personalCalendarDAY_NAME4;
		this.personalCalendarDAY_NAME5 = personalCalendarDAY_NAME5;
		this.personalCalendarDAY_NAME6 = personalCalendarDAY_NAME6;
		this.personalCalendarDAY_NAME7 = personalCalendarDAY_NAME7;
		this.personalCalendarDAY_NAME8 = personalCalendarDAY_NAME8;
		this.personalCalendarDAY_NAME9 = personalCalendarDAY_NAME9;
		this.personalCalendarDAY_NAME10 = personalCalendarDAY_NAME10;
		this.personalCalendarDAY_NAME11 = personalCalendarDAY_NAME11;
		this.personalCalendarDAY_NAME12 = personalCalendarDAY_NAME12;
		this.personalCalendarMONTH_NAME1 = personalCalendarMONTH_NAME1;
		this.personalCalendarMONTH_NAME2 = personalCalendarMONTH_NAME2;
		this.personalCalendarMONTH_NAME3 = personalCalendarMONTH_NAME3;
		this.personalCalendarMONTH_NAME4 = personalCalendarMONTH_NAME4;
		this.personalCalendarMONTH_NAME5 = personalCalendarMONTH_NAME5;
		this.personalCalendarMONTH_NAME6 = personalCalendarMONTH_NAME6;
		this.personalCalendarMONTH_NAME7 = personalCalendarMONTH_NAME7;
		this.personalCalendarMONTH_NAME8 = personalCalendarMONTH_NAME8;
		this.personalCalendarMONTH_NAME9 = personalCalendarMONTH_NAME9;
		this.personalCalendarMONTH_NAME10 = personalCalendarMONTH_NAME10;
		this.personalCalendarMONTH_NAME11 = personalCalendarMONTH_NAME11;
		this.personalCalendarMONTH_NAME12 = personalCalendarMONTH_NAME12;
		this.personalCalendarMONTH_NAME13 = personalCalendarMONTH_NAME13;
		this.personalCalendarMONTH_NAME14 = personalCalendarMONTH_NAME14;
		this.personalCalendarMONTH_NAME15 = personalCalendarMONTH_NAME15;
		this.personalCalendarMONTH_NAME16 = personalCalendarMONTH_NAME16;
		this.personalCalendarMONTH_NAME17 = personalCalendarMONTH_NAME17;
		this.personalCalendarMONTH_NAME18 = personalCalendarMONTH_NAME18;
		this.personalCalendarMONTH_NAME19 = personalCalendarMONTH_NAME19;
		this.personalCalendarMONTH_NAME20 = personalCalendarMONTH_NAME20;

	}
}