using System;

public class User
{


		private int userID {get; set;}
		private String? userEMAIL {get; set;}
		private String? userNAME {get; set;}
		private String? userPASSWORD {get; set;}
		private String? userLANGUAGE {get; set;}

	public User(int userID, String userEMAIL, String userNAME, String userPASSWORD, String userLANGUAGE) { 
		this.userID = userID;
		this.userEMAIL = userEMAIL;
		this.userNAME = userNAME;
		this.userPASSWORD = userPASSWORD;
		this.userLANGUAGE = userLANGUAGE;
	}


}