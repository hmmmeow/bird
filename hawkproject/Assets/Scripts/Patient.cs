using UnityEngine;
using System.Collections;

public class Patient : MonoBehaviour {



	public string getRandomFirstName(){

		string[] patientFName = {"Harry","John","Will","Thomas","Charlie","Felix","Dave","Mike","Steven","Ben","Rob","Matthew","Dennis","Brett","Joe","Justin","Lenny","Gavin"};

		int randomiser = Random.Range (0, patientFName.Length);

		string firstName = patientFName[randomiser];
		return firstName;
			

	}


	public string getRandomLastName(){


		string[] patientLName = {"Hobart","Smith","Dickinson","Cope","Gilder","Seddon","Swann","Dixon","Gellar","Green","Wright","Jackson","Moyes","Harris","Petit","Morgan","Biddle","Tank","Lewis","Robinson"};
		
		int randomiser = Random.Range (0, patientLName.Length);
		
		string lastName = patientLName[randomiser];
		return lastName;

		
	}


	public int getRandomAge(){
		
		
		int getAge = Random.Range (26, 79);
		
		return getAge;
		
		
	}



}


