using UnityEngine;
using System.Collections;
using SimpleJSON;
using System.IO;
using System.Runtime.Serialization;

public class PatientCatalogue : MonoBehaviour {

	public GameObject[] tagBedArea;
	public GameObject[] tagPatientName;
	public GameObject[] tagPatientAge;
	public GameObject[] tagPatientAddress;
	public GameObject[] tagPatientDiagnosis;
	public GameObject[] tagPatientSymptom;
	public GameObject[] tagPatientExamination;
	public GameObject[] tagPatientBlood;
	public GameObject[] tagPatientUs;
	public GameObject[] tagPatientXr;
	public GameObject[] tagPatientMri;
	public GameObject[] tagPatientTreatment;



	string firstName;
	string lastName;
	string fullName;
	int getAge;
	string diagnosisName;

	string patientName;
	string patientAge;
	string patientAddress;
	string patientDiagnosis;
	string patientSymptom;
	string patientExamination;
	string patientBlood;
	string patientUs;
	string patientXr;
	string patientMri;
	string patientTreatment;




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
		tagBedArea = GameObject.FindGameObjectsWithTag("BedArea");
		tagPatientName = GameObject.FindGameObjectsWithTag("PatientName");
		tagPatientAge = GameObject.FindGameObjectsWithTag("PatientAge");
		tagPatientAddress = GameObject.FindGameObjectsWithTag("PatientAddress");
		tagPatientDiagnosis = GameObject.FindGameObjectsWithTag("PatientDiagnosis");
		tagPatientSymptom = GameObject.FindGameObjectsWithTag("PatientSymptom");
		tagPatientExamination = GameObject.FindGameObjectsWithTag("PatientExamination");
		tagPatientUs = GameObject.FindGameObjectsWithTag("PatientUs");
		tagPatientXr = GameObject.FindGameObjectsWithTag("PatientXr");
		tagPatientMri = GameObject.FindGameObjectsWithTag("PatientMri");
		tagPatientTreatment = GameObject.FindGameObjectsWithTag("PatientTreatment");

		
		for(int i = 0; i < tagBedArea.Length; i++)
		{

			patientName = getRandomFullName();
			patientAge = getRandomAge() + " years old";
//			patientAddress = getRandomAddress();
			patientDiagnosis = getRandomDiagnosis();
//			patientSymptom = getRandomSymptom();
//			patientExamination = getRandomExamination() ;
//			patientBlood = getRandomBlood();
//			patientUs = getRandomUs();
//			patientXr = getRandomXr();
//			patientMri = getRandomMri();
//			patientTreatment = getRandomTreatment();


//			patientName = getRandomFullName() + "\n" + getRandomAge() + " years old";
//			
//			patientDiagnosis = "Main diagnosis: " + getRandomDiagnosis();
			
			tagBedArea[i].guiText.text = patientName + "\n" + patientAge + "\n\n\n" + patientDiagnosis;
			tagPatientName[i].guiText.text = patientName;
			tagPatientAge[i].guiText.text = patientAge;
//			tagPatientAddress[i].guiText.text = 
			tagPatientDiagnosis[i].guiText.text = patientDiagnosis;
//			tagPatientSymptom[i].guiText.text = 
//			tagPatientExamination[i].guiText.text = 
//			tagPatientUs[i].guiText.text = 
//			tagPatientXr[i].guiText.text = 
//			tagPatientMri[i].guiText.text = 
//			tagPatientTreatment[i].guiText.text = 




		}
	}



}


