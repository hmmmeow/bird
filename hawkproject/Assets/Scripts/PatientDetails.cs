using UnityEngine;
using System.Collections;


public class PatientDetails : MonoBehaviour {

	string firstName;
	string lastName;
	int age;

	//Diagnosis<List> diagnosis;
	//DrugAllergies drugAllergies;

	public void getPatientDetails()
	{
		firstName = myPatient.getRandomFirstName();
		lastName = myPatient.getRandomLastName();
		age = myPatient.getRandomAge();
		
	}
	
	

		
}
