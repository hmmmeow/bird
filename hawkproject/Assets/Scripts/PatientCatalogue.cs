using UnityEngine;
using System.Collections;
using SimpleJSON;
using System.IO;
using System.Runtime.Serialization;

public class PatientCatalogue : MonoBehaviour {

	// Find tagged GameObjects for each bedarea
	GameObject[] tagBedArea;
	GameObject[] tagPatientName;
	GameObject[] tagPatientAge;
	GameObject[] tagPatientHospitalNumber;
//	GameObject[] tagPatientAddress;
	GameObject[] tagPatientDiagnosis;
	GameObject[] tagPatientSymptom;
	GameObject[] tagPatientExamination;
	GameObject[] tagPatientThermometer;
	GameObject[] tagPatientBlood;
	GameObject[] tagPatientUs;
	GameObject[] tagPatientXr;
	GameObject[] tagPatientMri;
	GameObject[] tagPatientTreatment;


	// Patient bio and diagnosis
	string firstName;
	string lastName;
	string fullName;
	int getAge;
	int getHospitalNumber;

	string patientName;
	string patientAge;
	string patientHospitalNumber;
//	string patientAddress;
	string patientDiagnosis;
	string patientSymptom;
	string patientExamination;
	string patientThermometer;
	string patientBlood;
	string patientUs;
	string patientXr;
	string patientMri;
	string patientTreatment;


	// Returning randomised variables

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

	string getRandomFullName(){
		string firstName = getRandomFirstName();
		string lastName = getRandomLastName();
		fullName = firstName + " " + lastName;
		return fullName;		
	}

	int getRandomAge(){
		getAge = Random.Range (26, 79);
		return getAge;
	}

	int getRandomHospitalNumber(){
		getHospitalNumber = Random.Range (10000, 99999);
		return getHospitalNumber;
	}



	void diagnosisX(){


	string[,] records = new string[19,9] {
			{"Squits","Diarrhoea","Tender","High","Raised CRP","Normal","Normal","Normal","Squitamol"},
			{"Butterflitis","Diarrhoea","Normal","Normal","Normal","Butterflies","Normal","Normal","Amoxicitol"},
			{"Bowel entanglement","Diarrhoea","Tender","Normal","Normal","Normal","Entangled bowel","Normal","Transplant"},
			{"Hairyitis","Itchy","Hairy","High","Raised CRP","Normal","Normal","Normal","Electrolysis"},
			{"Dendritic rash","Itchy","Normal","Normal","Normal","Normal","Normal","Normal","Placebolin"},
			{"Light liver","Itchy","Normal","Normal","Deranged LFTs","Small liver","Normal","Normal","Transplant"},
			{"Crumblies","Back pain","Normal","Normal","Crumblies protein","Normal","Normal","Normal","Tixabrufen"},
			{"Spinal fusion","Back pain","Tender","Normal","Normal","Normal","Fused vertebrae","Normal","Decompression"},
			{"Rakeback syndrome","Back pain","Tender","Normal","Normal","Normal","Normal","Normal","Placebolin"},
			{"Lockjaw","Cannot speak","Lockjaw","Normal","Normal","Normal","Normal","Normal","Placebolin"},
			{"Mandibilitis","Cannot speak","Normal","High","Raised CRP","Normal","Normal","Normal","Squitamol"},
			{"Small brain anamoly","Cannot speak","Normal","Normal","Normal","Normal","Normal","Half brain","Transplant"},
			{"Radiolitis","Cannot see","Illuminates","Normal","Raised CRP","Normal","Normal","Normal","Amoxicitol"},
			{"Eye of Cthulyitis","Cannot see","Normal","Normal","Raised CRP","Inflammed eyes","Normal","Normal","Electrolysis"},
			{"Retinal polarisation","Cannot see","Normal","Normal","Polar antibodies","Normal","Normal","Normal","Transplant"},
			{"Distress syndrome","Breathless","Agitated","Normal","Normal","Normal","Normal","Normal","Placebolin"},
			{"Iron lung","Breathless","Normal","Normal","Normal","Normal","Iron lung","Normal","Transplant"},
			{"Chestdydilitis","Breathless","Normal","High","Raised CRP","Normal","Normal","Normal","Amoxicitol"},
			{"Plasmafied pleura","Breathless","Normal","High","Normal","Normal","Normal","Plasma","Decompression"}
			};
		
	
		int randomiser = Random.Range (0, 18);

		patientDiagnosis = records [randomiser,0];
		patientSymptom = records [randomiser,1];
		patientExamination = records [randomiser,2];
		patientThermometer = records [randomiser,3];
		patientBlood = records [randomiser,4];
		patientUs = records [randomiser,5];
		patientXr = records [randomiser,6];
		patientMri = records [randomiser,7];
		patientTreatment = records [randomiser,8];
		
	}



	// Assigning random variables to each bedarea

	void Start ()
	{
		tagBedArea = GameObject.FindGameObjectsWithTag("BedArea");
		tagPatientName = GameObject.FindGameObjectsWithTag("PatientName");
		tagPatientAge = GameObject.FindGameObjectsWithTag("PatientAge");
		tagPatientHospitalNumber = GameObject.FindGameObjectsWithTag("PatientHospitalNumber");
//		tagPatientAddress = GameObject.FindGameObjectsWithTag("PatientAddress");
		tagPatientDiagnosis = GameObject.FindGameObjectsWithTag("PatientDiagnosis");
		tagPatientSymptom = GameObject.FindGameObjectsWithTag("PatientSymptom");
		tagPatientExamination = GameObject.FindGameObjectsWithTag("PatientExamination");
		tagPatientThermometer = GameObject.FindGameObjectsWithTag("PatientThermometer");
		tagPatientBlood = GameObject.FindGameObjectsWithTag("PatientBlood");
		tagPatientUs = GameObject.FindGameObjectsWithTag("PatientUs");
		tagPatientXr = GameObject.FindGameObjectsWithTag("PatientXr");
		tagPatientMri = GameObject.FindGameObjectsWithTag("PatientMri");
		tagPatientTreatment = GameObject.FindGameObjectsWithTag("PatientTreatment");

		
		for(int i = 0; i < tagBedArea.Length; i++)
		{

			patientName = getRandomFullName();
			patientAge = getRandomAge() + "";
			patientHospitalNumber = "DIS0" + getRandomHospitalNumber();


			
			tagBedArea[i].guiText.text = patientName + ", " + patientAge + "\n" + patientHospitalNumber;
			tagPatientName[i].guiText.text = patientName;
			tagPatientAge[i].guiText.text = patientAge;
			tagPatientHospitalNumber[i].guiText.text = patientHospitalNumber;
//			tagPatientAddress[i].guiText.text = 


			diagnosisX();

			tagPatientDiagnosis[i].guiText.text = patientDiagnosis;
			tagPatientSymptom[i].guiText.text = patientSymptom;
			tagPatientExamination[i].guiText.text = "Examination findings: " + patientExamination;
			tagPatientThermometer[i].guiText.text = "Thermometer reading: " + patientThermometer;
			tagPatientBlood[i].guiText.text = "Blood report: " + patientBlood;
			tagPatientUs[i].guiText.text = "Ultrasound report: " + patientUs;
			tagPatientXr[i].guiText.text = "Xray report: " + patientXr;
			tagPatientMri[i].guiText.text = "MRI report: " + patientMri;
			tagPatientTreatment[i].guiText.text = patientTreatment;



		}
	}



}


