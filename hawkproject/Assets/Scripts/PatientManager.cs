using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PatientManager : MonoBehaviour {

	
	public int totalPatients;
//	int bedCount = 5;
	public GameObject patientPrefab;
	public List<GameObject> Patients = new List<GameObject> ();
	bool scriptStop = false;
	int k = 0;
	
	void PatientCreator()
	{
//		for(int k = 0; k < totalPatients; k++)
//		{
			GameObject patientObject = (GameObject)Instantiate(patientPrefab);
			Patients.Add(patientObject);
			patientObject.transform.SetParent(this.gameObject.transform, false);
			patientObject.name = "Patient" + k;
			Debug.Log(patientObject.name);
			patientObject.GetComponent<Transform>().localPosition = new Vector3(0,0,0);
//			yield return new WaitForSeconds(1f);
			scriptStop = false;
			k++;
//		}
	}
	
	
	
	void SpawnPatient()
	{
		if(Patients.Count < totalPatients && !scriptStop)
		{
			scriptStop = true;
			PatientCreator();
//			Invoke("PatientCreator", 1f);
			Invoke ("SpawnPatient", 8f);
		}
		else
		{
			Invoke ("SpawnPatient", 8f);
		}
	}
	
	
	
	
	// Use this for initialization
	void Awake () {
		SpawnPatient();
	}
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
