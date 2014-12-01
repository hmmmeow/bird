using UnityEngine;
using System.Collections;

public class Patient : MonoBehaviour {

	public string firstName;
	public string lastName;

	void Randomiser2000() {

		int randomiser = Random.Range (0, 10);

		if (randomiser != 5) {
			print (randomiser);
				} 

		}

	void Awake(){

		FirstName ();
		LastName ();
		print (firstName + " " + lastName);

		//Invoke ("FirstName", 0f);
		//Invoke ("LastName", 0f);


		}

	public void FirstName(){

		int FNmax = 9;
		string[] patientFName = new string[FNmax];

		patientFName [0] = "Harry";
		patientFName [1] = "John";
		patientFName [2] = "Will";
		patientFName [3] = "Thomas";
		patientFName [4] = "Charlie";
		patientFName [5] = "Boris";
		patientFName [6] = "Dave";
		patientFName [7] = "Mike";
		patientFName [8] = "Steven";

		int randomiser = Random.Range (0, FNmax);

		firstName = patientFName[randomiser];


	}


	public void LastName(){

		int LNmax = 12;
		string[] patientLName = new string[LNmax];

		patientLName [0] = "Hobart";
		patientLName [1] = "Smith";
		patientLName [2] = "Dickinson";
		patientLName [3] = "Cope";
		patientLName [4] = "Gilder";
		patientLName [5] = "Seddon";
		patientLName [6] = "Swann";
		patientLName [7] = "Dixon";
		patientLName [8] = "Gellar";
		patientLName [9] = "Green";
		patientLName [10] = "Wright";
		patientLName [11] = "Jackson";

		int randomiser = Random.Range (0, LNmax);
		
		lastName = patientLName[randomiser];

		
	}


	void patientNames() {

	}




}


