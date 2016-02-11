using UnityEngine;
using System.Collections;
using SimpleJSON;
using System.IO;
using System.Runtime.Serialization;

public class RNGManager : MonoBehaviour {


//	public GameObject bedArea;
	string[] rngArray = new string[13];
//	public string[] rngArray;
//	public int numberBeds = 2;

	// Patient bio and diagnosis
	string firstName;
	string lastName;
	string fullName;
	int getAge;
	int getHospitalNumber;
	int value; // randomise diagnosis

//	string patientLabel;
	
	string patientName;
	string patientAge;
	string patientHospitalNumber;
	string patientDiagnosis;
	string patientSymptom;
	string patientExamination;
	string patientThermometer;
	string patientBlood;
	string patientUs;
	string patientXr;
	string patientMri;
	string patientTreatment;

	string arrayDiagnosis;
	string arraySymptom;
	string arrayExamination;
	string arrayThermometer;
	string arrayBlood;
	string arrayUs;
	string arrayXr;
	string arrayMri;
	string arrayTreatment;

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
		getAge = Random.Range (26, 80);
		return getAge;
	}
	
	int getRandomHospitalNumber(){
		getHospitalNumber = Random.Range (10000, 99999);
		return getHospitalNumber;
	}
	
	
	
	void diagnosisX(){
		
		int value = Random.Range (0, 18);
		
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
		
		
		arrayDiagnosis = records [value,0];
		arraySymptom = records [value,1];
		arrayExamination = records [value,2];
		arrayThermometer = records [value,3];
		arrayBlood = records [value,4];
		arrayUs = records [value,5];
		arrayXr = records [value,6];
		arrayMri = records [value,7];
		arrayTreatment = records [value,8];
		
		return;
		
	}
	
	
	
	// Assigning random variables to each bedarea

	public void getRNG() {
										
			patientName = getRandomFullName();
			patientAge = getRandomAge() + "";
			patientHospitalNumber = "DIS0" + getRandomHospitalNumber();
			
			diagnosisX();

			patientDiagnosis = arrayDiagnosis;
			patientSymptom = arraySymptom;
			patientExamination = arrayExamination;
			patientThermometer = arrayThermometer;
			patientBlood = arrayBlood;
			patientUs = arrayUs;
			patientXr = arrayXr;
			patientMri = arrayMri;
			patientTreatment = arrayTreatment;

		rngArray [0] = patientName;
		rngArray [1] = patientAge;
		rngArray [2] = patientHospitalNumber;
		rngArray [3] = patientDiagnosis;
		rngArray [4] = patientSymptom;
		rngArray [5] = patientExamination;
		rngArray [6] = patientThermometer;
		rngArray [7] = patientBlood;
		rngArray [8] = patientUs;
		rngArray [9] = patientXr;
		rngArray [10] = patientMri;
		rngArray [11] = patientTreatment;

//		string[] rngArray = new string[]{patientDiagnosis,patientSymptom};
//		Debug.Log (patientDiagnosis);
//		Debug.Log (rngArray[0]);

						
	}

	public string GetArray(int parameter) {

		string returnvalue;
		returnvalue = rngArray [parameter];

		return returnvalue;
	}



//	void Start()
//	{
//		getRNG ();
//		Debug.Log (rngArray [0]);
//	}
}
	
	
	


