using UnityEngine;
using System.Collections;


public static class PatientDetails : MonoBehaviour {


	//Diagnosis<List> diagnosis;
	//DrugAllergies drugAllergies;

	var myPatient = new Patient();


	public Patient;
	
	public void getPatientDetails()
	{
		string firstName = myPatient.getRandomFirstName();
		string lastName = myPatient.getRandomLastName();
		int age = myPatient.getRandomAge();
		
	}
	
	

		
}
