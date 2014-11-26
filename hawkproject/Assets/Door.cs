using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {


	public Transform doorTrigger;
	public Transform doorObjectA;
	public Transform doorObjectB;


		//void OnTriggerEnter2D(Collider2D other)
		//	{
		//		Invoke ("DoorOpen", 0f);
		//	}

		void OnTriggerEnter2D(Collider2D other)
			{
				Invoke ("DoorOpen", 0f);
			}

		void OnTriggerExit2D(Collider2D other)
			{
				Invoke ("DoorClose", 0f);
			}

						
		void DoorOpen()
			{
				doorObjectA.transform.position = new Vector3 (doorObjectA.position.x - 1, doorObjectA.position.y, doorObjectA.position.z);
				doorObjectB.transform.position = new Vector3 (doorObjectB.position.x + 1, doorObjectB.position.y, doorObjectB.position.z);
				//doorTrigger.transform.position = new Vector3 (doorTrigger.position.x - 12, doorTrigger.position.y, doorTrigger.position.z);
			}
			
			void DoorClose()
			{
				doorObjectA.transform.position = new Vector3 (doorObjectA.position.x + 1, doorObjectA.position.y, doorObjectA.position.z);
				doorObjectB.transform.position = new Vector3 (doorObjectB.position.x - 1, doorObjectB.position.y, doorObjectB.position.z);
				//doorTrigger.transform.position = new Vector3 (doorTrigger.position.x + 12, doorTrigger.position.y, doorTrigger.position.z);
			}

}
