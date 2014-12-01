using UnityEngine;
using System.Collections;

public class Patient : MonoBehaviour {


	void Randomiser2000() {

		int randomiser = Random.Range (0, 10);

		if (randomiser != 5) {
			print (randomiser);
				} 

		}

	void Awake(){
		print (getRandomFirstName() + " " + getRandomLastName());

		}


	public string getRandomFirstName(){

		string[] patientFName = {"Harry","John","Will","Thomas","Charlie","Boris","Dave","Mike","Steven"};

		int randomiser = Random.Range (0, patientFName.Length);

		string firstName = patientFName[randomiser];
		return firstName;
			

	}


	public string getRandomLastName(){


		string[] patientLName = {"Hobart","Smith","Dickinson","Cope","Gilder","Seddon","Swann","Dixon","Gellar","Green","Wright","Jackson","Moyes"};
		
		int randomiser = Random.Range (0, patientLName.Length);
		
		string lastName = patientLName[randomiser];
		return lastName;

		
	}


	public string getRandomAge(){
		
		
		int getAge = Random.Range (30, 75);
		
		return getAge;
		
		
	}



}


