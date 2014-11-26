using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public Transform doorTrigger;
	public Transform doorObject;

	void OnTriggerEnter2D(Collider2D other) 
	{
		Invoke ("DoorOpen", 0f);
	}
	
	void DoorOpen()
	{
		doorObject.transform.position = new Vector3 (doorObject.position.x - 3, doorObject.position.y, doorObject.position.z);
		doorTrigger.transform.position = new Vector3 (doorTrigger.position.x - 20, doorTrigger.position.y, doorTrigger.position.z);
		Invoke ("DoorClose", 3f);
	}
	
	void DoorClose()
	{
		doorObject.transform.position = new Vector3 (doorObject.position.x + 3, doorObject.position.y, doorObject.position.z);
		doorTrigger.transform.position = new Vector3 (doorTrigger.position.x + 20, doorTrigger.position.y, doorTrigger.position.z);
	}



}
