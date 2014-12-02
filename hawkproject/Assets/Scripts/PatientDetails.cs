using UnityEngine;
using System.Collections;

public class PatientDetails : MonoBehaviour {

	public Patient patient;
	string firstName;
	string lastName;
	string fullName;
	int age;

//	Diagnosis<List> diagnosis;
//	DrugAllergies drugAllergies;

	public string patientFullName()
	{
		firstName = patient.getRandomFirstName();
		lastName = patient.getRandomLastName();
		fullName = firstName + " " + lastName;
		return fullName;
				
	}

	public int patientAge()
	{
		age = patient.getRandomAge();
		return age;
		
	}

//	void Start(){
//		patientFullName ();
//		patientAge ();
//		/print (fullName + " is " + age + " years old");
//		
//	}

		
}
