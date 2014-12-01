using UnityEngine;
using System.Collections;

public class PatientDetails : MonoBehaviour {

	Patient myPatient;
	string firstName;
	string lastName;
	int age;

//	Diagnosis<List> diagnosis;
//	DrugAllergies drugAllergies;

	public void getPatientDetails()
	{
		Patient myPatient = new Patient();
		firstName = myPatient.getRandomFirstName();
		lastName = myPatient.getRandomLastName();
		age = myPatient.getRandomAge();
		
	}
	
	void Awake(){
		print (firstName + " " + lastName + " is " + age + " years old");
		
	}

		
}
