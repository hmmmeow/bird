using UnityEngine;
using System.Collections;
using SimpleJSON;
using System.IO;
using System.Runtime.Serialization;

public class PatientCatalogue : MonoBehaviour {

	public GameObject[] bedspace;

	string firstName;
	string lastName;
	string fullName;
	int getAge;
	string diagnosisName;

	string patientBio;
	string patientDiagnosis;
	string patientSymptoms;




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


	void Start ()
	{
		bedspace = GameObject.FindGameObjectsWithTag("BedArea");
		
		for(int i = 0; i < bedspace.Length; i++)
		{

			patientBio = getRandomFullName() + "\n" + getRandomAge() + " years old";
			
			patientDiagnosis = "Main diagnosis: " + getRandomDiagnosis();
			
			bedspace[i].guiText.text = patientBio + "\n" + patientDiagnosis;

		}
	}



}


