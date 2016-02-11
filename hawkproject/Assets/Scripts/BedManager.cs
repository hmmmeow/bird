using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BedManager : MonoBehaviour {

	public PatientManager pm;
	public int bedCount;
	public GameObject bedPrefab;
//	public List<GameObject> Bed = new List<GameObject> ();
//	public List<BedAllocation> Bed = new List<BedAllocation> ();
	
	bool go;
	
	
	void CreateBedAreas()
	{
		int x = (-bedCount + 1) * 5;
		for(int k = 0; k < bedCount; k++)
		{
			GameObject bed = (GameObject)Instantiate(bedPrefab);
//			Bed.Add(new BedAllocation());
			bed.transform.SetParent(this.gameObject.transform, false);
			bed.name = "Bed" + k;
			bed.GetComponent<Transform>().localPosition = new Vector3(x,3,0);
			x = x + 10;
		}
	}


//	public void addPatient()
//	{
//		for (int i = 0; i < pm.Patients.Count; i++)
//		{
//			if(pm.Patients[i].gameObject.name == "Patient"+i)
//			{
//				BedAllocation bed = database.items[i];
//				addPatientEmptyBed(bed);
//				break;
//			}
//		}
//	}
//	
	
//	void addPatientToEmptyBed()
//	{
//		for (int i = 0; i < Bed.Count; i++)
//		{
//			if(Bed[i] == null)
//			{
//				for (int k = 0; k < pm.Patients.Count; k++)
//				{		
//					for (int l = 0; l < pm.Patients.Count; l++)
//					{		
//						if(pm.Patients[l].gameObject.name != "Patient"+k)
//						{
//							go = true;
//						}else{
//							go = false;
//						}
//						
//						if(pm.Patients[k].gameObject.name == "Patient"+k && go)
//						{
//							Bed[i] = new GameObject(pm.Patients[k]);
//	//						Bed[i] = new BedAllocation(i, pm.Patients[k], "no");
//							Debug.Log(Bed[1]);
//							break;
//						}
//					}
//				}
//			}
//		}	
//	}

	// Use this for initialization
	void Awake () {
		CreateBedAreas();
//		Invoke("addPatientToEmptyBed",4f);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
}
