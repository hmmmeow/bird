using UnityEngine;
using System.Collections;

public class PatientDetails : MonoBehaviour {

	public Patient patient;
	string firstName;
	string lastName;
	int age;

//	Diagnosis<List> diagnosis;
//	DrugAllergies drugAllergies;

	public void patientDetails()
	{
		//Patient myPatient = new Patient();
		firstName = patient.getRandomFirstName();
		lastName = patient.getRandomLastName();
		age = patient.getRandomAge();
		
	}

	void Start(){
		patientDetails ();
		print (firstName + " " + lastName + " is " + age + " years old");
		
	}

		
}
