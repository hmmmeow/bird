using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PatientData : MonoBehaviour {


//	GameObject gameManager;
	RNGManager rng;

	public bool questPatient;
	public int visitorNumber;
	public int assignedBedNumber;
	public string patientName;
	public string patientAge;
	public string patientHospitalNumber;
	public string patientLabel;
	public string patientDiagnosis;
	public string patientSymptom;
	public string patientExamination;
	public string patientThermometer;
	public string patientBlood;
	public string patientUs;
	public string patientXr;
	public string patientMri;
	public string correctTreatment;
	public string currentTreatment;
	public bool patientDead;
	public bool patientCured;
	public int health;
	public int deathTimer;
	public int targetTimer;
	
	public bool patientInBedZone;
	public Vector3 allocatedBedVector3;

	
//	GameObject medicalRecord;
//	GameObject biographicsPages;
//	GameObject diagnosticsPages;
//	GameObject treatmentPages;
//	GameObject player;
	

	void Awake ()
	{
		rng = GameObject.Find ("RNGManager").GetComponent<RNGManager> ();
		AcquirePatientData ();
		BreachTarget();
		
//		player = GameObject.Find("Player1");

	}
	

//	void UpdateVisitorNumber ()
//	{
//		visitorNumber = gameObject.name;
//	}
	
	void AcquirePatientData()
	{
		rng.getRNG ();
		
//		Invoke("UpdateVisitorNumber",1f);
		patientName = rng.GetArray (0);
		patientAge = rng.GetArray (1);
		patientHospitalNumber = rng.GetArray (2);
		patientDiagnosis = rng.GetArray (3);
		patientSymptom = rng.GetArray (4);
		patientExamination = rng.GetArray (5);
		patientThermometer = rng.GetArray (6);
		patientBlood = rng.GetArray (7);
		patientUs = rng.GetArray (8);
		patientXr = rng.GetArray (9);
		patientMri = rng.GetArray (10);
		correctTreatment = rng.GetArray (11);
		currentTreatment = "No treatment";
		questPatient = false;
		patientDead = false;
		patientCured = false;
		health = 2;
		deathTimer = 20000;
		targetTimer = 200;
		
		patientInBedZone = false;
//		patientPositionX = gameObject.transform.position.x;
//		patientPositionY = gameObject.transform.position.y;
		

		patientLabel = patientName + ", " + patientAge + "\n" + patientHospitalNumber;
		
	}
	
	
	void BreachTarget()
	{
		if(targetTimer <= 0)
		{
			Debug.Log("gameObject Destroyed");
			Destroy(gameObject);
		}
		else if(targetTimer > 0)
		{
			targetTimer = targetTimer - 5;
			Invoke("BreachTarget",5f);
		}
	}

	
//	public void OpenMedicalRecord()
//	{
//		medicalRecord = GameObject.Find ("MedicalRecord");
//		biographicsPages = GameObject.Find ("BiographicsPages");
//		diagnosticsPages = GameObject.Find ("DiagnosticsPages");
//		treatmentPages = GameObject.Find ("TreatmentPages");
//		
//		medicalRecord.SetActive (true);	
//		// Populate pages
//		biographicsPages.SetActive (true);
//		diagnosticsPages.SetActive (true);
//		treatmentPages.SetActive (true);
//		// Update patientlabels
//		
//		GameObject.Find("MainLabel").GetComponent<Text>().text = patientLabel;
//		GameObject.Find("BiographicsLabel").GetComponent<Text>().text = patientLabel;
//		GameObject.Find("DiagnosticsLabel").GetComponent<Text>().text = patientLabel;
//		GameObject.Find("TreatmentLabel").GetComponent<Text>().text = patientLabel;
//		GameObject.Find("CurrentTreatmentLabel").GetComponent<Text>().text = currentTreatment;
//		// Close pages
//		biographicsPages.SetActive (false);
//		diagnosticsPages.SetActive (false);
//		treatmentPages.SetActive (false);
//	}

//			result = rng.GetArray (value);
		
//	rng = GameObject.Find ("GameManager");
//	
//				rng.getRNG ();
//

//
//		patientName = rng.MyRNG[0];
//		patientAge;
//		patientHospitalNumber;
//		patientDiagnosis;
//		patientSymptom;
//		patientExamination;
//		patientThermometer;
//		patientBlood;
//		patientUs;
//		patientXr;
//		patientMri;
//		patientTreatment;




}
