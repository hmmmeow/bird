using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class PatientZone : MonoBehaviour {
	
	PatientData patientData;
	public UIManager uim;

	GameObject player;
	
	public bool playerInZone;
	
	
	void Awake()
	{
		player = GameObject.Find("Player1");
		patientData = this.gameObject.GetComponent<PatientData> ();
		uim = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager> ();
//		uim.medicalPages[0].SetActive(true);
	}
	
		
	
	void OpenMedicalRecord()
	{
			
		uim.medicalPages[0].SetActive(true);
		uim.medicalPages[1].SetActive(true);
		uim.medicalPages[2].SetActive(true);
		uim.medicalPages[3].SetActive(true);
		// Update patientlabels
		
		
//		uim.medicalLabels[0] = patientData.patientLabel;
		uim.stickyLabels[0].GetComponent<Text>().text = patientData.patientLabel;
		uim.stickyLabels[1].GetComponent<Text>().text = patientData.patientLabel;
		uim.stickyLabels[2].GetComponent<Text>().text = patientData.patientLabel;
		uim.stickyLabels[3].GetComponent<Text>().text = patientData.patientLabel;
		uim.currentTreatmentLabel.GetComponent<Text>().text = patientData.currentTreatment;
		
//		GameObject.Find("MainLabel").GetComponent<Text>().text = patientData.patientLabel;
//		GameObject.Find("BiographicsLabel").GetComponent<Text>().text = patientData.patientLabel;
//		GameObject.Find("DiagnosticsLabel").GetComponent<Text>().text = patientData.patientLabel;
//		GameObject.Find("TreatmentLabel").GetComponent<Text>().text = patientData.patientLabel;
//		GameObject.Find("CurrentTreatmentLabel").GetComponent<Text>().text = patientData.currentTreatment;
		
		// Close pages
		uim.medicalPages[1].SetActive(false);
		uim.medicalPages[2].SetActive(false);
		uim.medicalPages[3].SetActive(false);
	}
	
	public void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject == player)
		{
			playerInZone = true;
			Debug.Log(patientData.patientName);
//			patientData = this.gameObject.GetComponentInParent<PatientData>();
		}
	}
	public void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject == player)
		{
			playerInZone = false;
		}
	}
	
	bool PlayerInZone() {return playerInZone;}
	
	
	void Update()
	{
		if(playerInZone)
		{
			if (Input.GetMouseButtonDown (0)) //&& !medicalRecord.gameObject.activeSelf
			{
				OpenMedicalRecord();			
			}
		}
		
		
	}
	
	
}

