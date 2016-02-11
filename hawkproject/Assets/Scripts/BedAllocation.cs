using UnityEngine;
using System.Collections;

public class BedAllocation {

	public int bedID;
	public GameObject patientGameObject;
	public string bedVacant;
	
	public BedAllocation(int id, GameObject patientObj, string vacant)
	{
		bedID = id;
		patientGameObject = patientObj;
		bedVacant = vacant;
		
	}
	public BedAllocation(){}
}
