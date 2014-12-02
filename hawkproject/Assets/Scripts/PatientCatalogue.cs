using UnityEngine;
using System.Collections;

public class PatientCatalogue : MonoBehaviour {

	string firstName;
	string lastName;
	string fullName;
	int getAge;
	string diagnosisName;
	string associatedSymptoms;

	string getRandomFirstName(){
		string[] patientFName = {"Harry","John","Will","Thomas","Charlie","Felix","Dave","Mike","Steven","Ben","Rob","Matthew","Dennis","Brett","Joe","Justin","Lenny","Gavin"};
		int randomiser = Random.Range (0, patientFName.Length);
		firstName = patientFName[randomiser];
		return firstName;
	}

	string getRandomLastName(){
		string[] patientLName = {"Hobart","Smith","Dickinson","Cope","Gilder","Seddon","Swann","Dixon","Gellar","Green","Wright","Jackson","Moyes","Harris","Petit","Morgan","Biddle","Tank","Lewis","Robinson"};
		int randomiser = Random.Range (0, patientLName.Length);
		lastName = patientLName[randomiser];
		return lastName;
	}

	public string getRandomFullName()
	{
		string firstName = getRandomFirstName();
		string lastName = getRandomLastName();
		fullName = firstName + " " + lastName;
		return fullName;
		
	}

	public int getRandomAge(){
		getAge = Random.Range (26, 79);
		return getAge;
	}

	public string getRandomDiagnosis(){
		string[] patientDiagnosis = {"Squits","Hairyitis","Dendritic rash","Crumblies"};
		int randomiser = Random.Range (0, patientDiagnosis.Length);
		diagnosisName = patientDiagnosis[randomiser];
		return diagnosisName;
	}

	// randomiser ends here

//	void symptomsFromDiagnosis(){
//
//
//		if  (diagnosisName == null) {
//			associatedSymptoms = "D'oh!";
//		}
//
//		// symptoms based on random diagnosis - are these classes now?
//
//		if  (diagnosisName == "Squits") {
//			associatedSymptoms = "Diarrhoea";
//		}
//		if  (diagnosisName == "Hairyitis") {
//			associatedSymptoms = "Itchy";
//		}
//		if  (diagnosisName == "Dendritic rash") {
//			associatedSymptoms = "Itchy";
//		}
//		if  (diagnosisName == "Crumblies") {
//			associatedSymptoms = "Back pain";
//		}
//
//	}

//	public string getAssociatedSymptoms(){
//
//		symptomsFromDiagnosis ();
//		return associatedSymptoms;
//				
//	
//	}



}


