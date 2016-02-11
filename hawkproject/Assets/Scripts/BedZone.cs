using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BedZone : MonoBehaviour {

	PatientData patientData;

	GameObject assignedPatient;



	bool inBedarea;


	void Awake(){
//		patientData = this.gameObject.GetComponent<PatientData> ();
		
		}

//
//	bool AssignPatientToBed()
//	{
//		if (assignedPatient == null)
//		{
//		
//		}
//	}



	public void OnTriggerEnter2D(Collider2D other)
		{
			if(other.gameObject == assignedPatient)
			{
			inBedarea = true;
			}
		}
	public void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject == assignedPatient)
		{
			inBedarea = false;
		}
	}

	public bool BedAreaCheck() {return inBedarea;}


	void Update()
	{

			
	}


}
	
