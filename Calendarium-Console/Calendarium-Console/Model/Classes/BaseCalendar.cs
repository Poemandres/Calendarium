using System;

public class BaseCalendar
{

		private int baseCalendarID {get; set;} 
		private String? baseCalendarNAME {get; set;} 
		private int baseCalendarCATEGORY {get; set;} 
		private String? baseCalendarGROUP {get; set;} 
		private String? baseCalendarURL {get; set;} 
		private int baseCalendarORDER {get; set;} 
		private bool baseCalendarFIRST_DAY {get; set;} 
		private int baseCalendarNEW_YEAR {get; set;} 
		private int baseCalendarICON {get; set;} 
		private int baseCalendarMONTH_AMOUNT {get; set;} 
		private int baseCalendarLEAP_DAY_MONTH {get; set;} 
		private int baseCalendarLEAP_DAY_PLACE {get; set;} 
		private int baseCalendarLEAP_DAY_START {get; set;} 
		private int baseCalendarLEAP_DAY_DISTANCE {get; set; }
		private String? baseCalendarDAY_NAME1 { get; set; }
		private String? baseCalendarDAY_NAME2 { get; set; }
		private String? baseCalendarDAY_NAME3 { get; set; }
		private String? baseCalendarDAY_NAME4 { get; set; }
		private String? baseCalendarDAY_NAME5 { get; set; }
		private String? baseCalendarDAY_NAME6 { get; set; }
		private String? baseCalendarDAY_NAME7 { get; set; }
		private String? baseCalendarMONTH_NAME1 {get; set;} 
		private String? baseCalendarMONTH_NAME2 {get; set;} 
		private String? baseCalendarMONTH_NAME3 {get; set;} 
		private String? baseCalendarMONTH_NAME4 {get; set;} 
		private String? baseCalendarMONTH_NAME5 {get; set;} 
		private String? baseCalendarMONTH_NAME6 {get; set;} 
		private String? baseCalendarMONTH_NAME7 {get; set;} 
		private String? baseCalendarMONTH_NAME8 {get; set;} 
		private String? baseCalendarMONTH_NAME9 {get; set;} 
		private String? baseCalendarMONTH_NAME10 {get; set;} 
		private String? baseCalendarMONTH_NAME11 {get; set;} 
		private String? baseCalendarMONTH_NAME12 {get; set;} 
		private String? baseCalendarMONTH_NAME13 {get; set;} 
		private String? baseCalendarMONTH_NAME14 {get; set;} 
		private String? baseCalendarMONTH_NAME15 {get; set;} 
		private String? baseCalendarMONTH_NAME16 {get; set;} 
		private String? baseCalendarMONTH_NAME17 {get; set;} 
		private String? baseCalendarMONTH_NAME18 {get; set;} 
		private String? baseCalendarMONTH_NAME19 {get; set;} 
		private String? baseCalendarMONTH_NAME20 {get; set;} 
		private int baseCalendarMONTH_DURATION1 {get; set;} 
		private int baseCalendarMONTH_DURATION2 {get; set;} 
		private int baseCalendarMONTH_DURATION3 {get; set;} 
		private int baseCalendarMONTH_DURATION4 {get; set;} 
		private int baseCalendarMONTH_DURATION5 {get; set;} 
		private int baseCalendarMONTH_DURATION6 {get; set;} 
		private int baseCalendarMONTH_DURATION7 {get; set;} 
		private int baseCalendarMONTH_DURATION8 {get; set;} 
		private int baseCalendarMONTH_DURATION9 {get; set;} 
		private int baseCalendarMONTH_DURATION10 {get; set;} 
		private int baseCalendarMONTH_DURATION11 {get; set;} 
		private int baseCalendarMONTH_DURATION12 {get; set;} 
		private int baseCalendarMONTH_DURATION13 {get; set;} 
		private int baseCalendarMONTH_DURATION14 {get; set;} 
		private int baseCalendarMONTH_DURATION15 {get; set;} 
		private int baseCalendarMONTH_DURATION16 {get; set;} 
		private int baseCalendarMONTH_DURATION17 {get; set;} 
		private int baseCalendarMONTH_DURATION18 {get; set;} 
		private int baseCalendarMONTH_DURATION19 {get; set;} 
		private int baseCalendarMONTH_DURATION20 {get; set;} 
	
	public BaseCalendar(int baseCalendarID, String baseCalendarNAME, int baseCalendarCATEGORY, String baseCalendarGROUP, String baseCalendarURL, int baseCalendarORDER, 
		bool baseCalendarFIRST_DAY, int baseCalendarNEW_YEAR, int baseCalendarICON, int baseCalendarMONTH_AMOUNT, int baseCalendarLEAP_DAY_MONTH, int baseCalendarLEAP_DAY_PLACE,
		int baseCalendarLEAP_DAY_START, int baseCalendarLEAP_DAY_DISTANCE,
		String baseCalendarDAY_NAME1, String baseCalendarDAY_NAME2, String baseCalendarDAY_NAME3, String baseCalendarDAY_NAME4, String baseCalendarDAY_NAME5,
		String baseCalendarDAY_NAME6, String baseCalendarDAY_NAME7,
		String baseCalendarMONTH_NAME1, String baseCalendarMONTH_NAME2, String baseCalendarMONTH_NAME3, String baseCalendarMONTH_NAME4, String baseCalendarMONTH_NAME5,
		String baseCalendarMONTH_NAME6, String baseCalendarMONTH_NAME7, String baseCalendarMONTH_NAME8, String baseCalendarMONTH_NAME9, String baseCalendarMONTH_NAME10,
		String baseCalendarMONTH_NAME11, String baseCalendarMONTH_NAME12, String baseCalendarMONTH_NAME13, String baseCalendarMONTH_NAME14, String baseCalendarMONTH_NAME15,
		String baseCalendarMONTH_NAME16, String baseCalendarMONTH_NAME17, String baseCalendarMONTH_NAME18, String baseCalendarMONTH_NAME19, String baseCalendarMONTH_NAME20,
		int baseCalendarMONTH_DURATION1, int baseCalendarMONTH_DURATION2, int baseCalendarMONTH_DURATION3, int baseCalendarMONTH_DURATION4, int baseCalendarMONTH_DURATION5,
		int baseCalendarMONTH_DURATION6, int baseCalendarMONTH_DURATION7, int baseCalendarMONTH_DURATION8, int baseCalendarMONTH_DURATION9, int baseCalendarMONTH_DURATION10,
		int baseCalendarMONTH_DURATION11, int baseCalendarMONTH_DURATION12, int baseCalendarMONTH_DURATION13, int baseCalendarMONTH_DURATION14, int baseCalendarMONTH_DURATION15,
		int baseCalendarMONTH_DURATION16, int baseCalendarMONTH_DURATION17, int baseCalendarMONTH_DURATION18, int baseCalendarMONTH_DURATION19, int baseCalendarMONTH_DURATION20){
		this.baseCalendarID = baseCalendarID;
		this.baseCalendarNAME = baseCalendarNAME;
		this.baseCalendarCATEGORY = baseCalendarCATEGORY;
		this.baseCalendarGROUP = baseCalendarGROUP;
		this.baseCalendarURL = baseCalendarURL;
		this.baseCalendarORDER = baseCalendarORDER;
		this.baseCalendarFIRST_DAY = baseCalendarFIRST_DAY;
		this.baseCalendarNEW_YEAR = baseCalendarNEW_YEAR;
		this.baseCalendarICON = baseCalendarICON;
		this.baseCalendarMONTH_AMOUNT = baseCalendarMONTH_AMOUNT;
		this.baseCalendarLEAP_DAY_MONTH = baseCalendarLEAP_DAY_MONTH;
		this.baseCalendarLEAP_DAY_PLACE = baseCalendarLEAP_DAY_PLACE;
		this.baseCalendarLEAP_DAY_START = baseCalendarLEAP_DAY_START;
		this.baseCalendarLEAP_DAY_DISTANCE = baseCalendarLEAP_DAY_DISTANCE;
		this.baseCalendarDAY_NAME1 = baseCalendarDAY_NAME1;
		this.baseCalendarDAY_NAME2 = baseCalendarDAY_NAME2;
		this.baseCalendarDAY_NAME3 = baseCalendarDAY_NAME3;
		this.baseCalendarDAY_NAME4 = baseCalendarDAY_NAME4;
		this.baseCalendarDAY_NAME5 = baseCalendarDAY_NAME5;
		this.baseCalendarDAY_NAME6 = baseCalendarDAY_NAME6;
		this.baseCalendarDAY_NAME7 = baseCalendarDAY_NAME7;
		this.baseCalendarMONTH_NAME1 = baseCalendarMONTH_NAME1;
		this.baseCalendarMONTH_NAME2 = baseCalendarMONTH_NAME2;
		this.baseCalendarMONTH_NAME3 = baseCalendarMONTH_NAME3;
		this.baseCalendarMONTH_NAME4 = baseCalendarMONTH_NAME4;
		this.baseCalendarMONTH_NAME5 = baseCalendarMONTH_NAME5;
		this.baseCalendarMONTH_NAME6 = baseCalendarMONTH_NAME6;
		this.baseCalendarMONTH_NAME7 = baseCalendarMONTH_NAME7;
		this.baseCalendarMONTH_NAME8 = baseCalendarMONTH_NAME8;
		this.baseCalendarMONTH_NAME9 = baseCalendarMONTH_NAME9;
		this.baseCalendarMONTH_NAME10 = baseCalendarMONTH_NAME10;
		this.baseCalendarMONTH_NAME11 = baseCalendarMONTH_NAME11;
		this.baseCalendarMONTH_NAME12 = baseCalendarMONTH_NAME12;
		this.baseCalendarMONTH_NAME13 = baseCalendarMONTH_NAME13;
		this.baseCalendarMONTH_NAME14 = baseCalendarMONTH_NAME14;
		this.baseCalendarMONTH_NAME15 = baseCalendarMONTH_NAME15;
		this.baseCalendarMONTH_NAME16 = baseCalendarMONTH_NAME16;
		this.baseCalendarMONTH_NAME17 = baseCalendarMONTH_NAME17;
		this.baseCalendarMONTH_NAME18 = baseCalendarMONTH_NAME18;
		this.baseCalendarMONTH_NAME19 = baseCalendarMONTH_NAME19;
		this.baseCalendarMONTH_NAME20 = baseCalendarMONTH_NAME20;
		this.baseCalendarMONTH_DURATION1 = baseCalendarMONTH_DURATION1;
		this.baseCalendarMONTH_DURATION2 = baseCalendarMONTH_DURATION2;
		this.baseCalendarMONTH_DURATION3 = baseCalendarMONTH_DURATION3;
		this.baseCalendarMONTH_DURATION4 = baseCalendarMONTH_DURATION4;
		this.baseCalendarMONTH_DURATION5 = baseCalendarMONTH_DURATION5;
		this.baseCalendarMONTH_DURATION6 = baseCalendarMONTH_DURATION6;
		this.baseCalendarMONTH_DURATION7 = baseCalendarMONTH_DURATION7;
		this.baseCalendarMONTH_DURATION8 = baseCalendarMONTH_DURATION8;
		this.baseCalendarMONTH_DURATION9 = baseCalendarMONTH_DURATION9;
		this.baseCalendarMONTH_DURATION10 = baseCalendarMONTH_DURATION10;
		this.baseCalendarMONTH_DURATION11 = baseCalendarMONTH_DURATION11;
		this.baseCalendarMONTH_DURATION12 = baseCalendarMONTH_DURATION12;
		this.baseCalendarMONTH_DURATION13 = baseCalendarMONTH_DURATION13;
		this.baseCalendarMONTH_DURATION14 = baseCalendarMONTH_DURATION14;
		this.baseCalendarMONTH_DURATION15 = baseCalendarMONTH_DURATION15;
		this.baseCalendarMONTH_DURATION16 = baseCalendarMONTH_DURATION16;
		this.baseCalendarMONTH_DURATION17 = baseCalendarMONTH_DURATION17;
		this.baseCalendarMONTH_DURATION18 = baseCalendarMONTH_DURATION18;
		this.baseCalendarMONTH_DURATION19 = baseCalendarMONTH_DURATION19;
		this.baseCalendarMONTH_DURATION20 = baseCalendarMONTH_DURATION20;

	}


}