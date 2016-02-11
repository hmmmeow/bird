using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PatientManager : MonoBehaviour {

	
	public int maxPatients;
	public int spawnRate;
//	int bedCount = 5;
	public GameObject patientPrefab;
//	public List<GameObject> Patients = new List<GameObject> ();
	
	public Queue<GameObject> patientQueue = new Queue<GameObject>();
	
	
	bool scriptStop = false;
	int k = 0;
	
	void PatientCreator()
	{
//		for(int k = 0; k < totalPatients; k++)
//		{
			GameObject patientObject = (GameObject)Instantiate(patientPrefab);
//			Patients.Add(patientObject);
			patientQueue.Enqueue(patientObject);
			patientObject.transform.SetParent(this.gameObject.transform, false);
			patientObject.name = "Patient" + k;
			PatientData pd = patientObject.GetComponent<PatientData>();
			pd.visitorNumber = k;
//			Debug.Log(patientObject.name);
			patientObject.GetComponent<Transform>().localPosition = new Vector3(0,0,0);
//			yield return new WaitForSeconds(1f);
			scriptStop = false;
			k++;
			
//		foreach(GameObject obj in patientQueue)
//		{
//			Debug.Log(obj);
//		}
			
//		}
	}
	
	
	
	void SpawnPatient()
	{
		if(patientQueue.Count < maxPatients && !scriptStop)
		{
			scriptStop = true;
			PatientCreator();
//			Invoke("PatientCreator", 1f);
			Invoke ("SpawnPatient", spawnRate);
		}
		else
		{
			Invoke ("SpawnPatient", spawnRate);
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
