using UnityEngine;
using System.Collections;

public class KeyPickup : MonoBehaviour
{
	//public AudioClip keyGrab;                       // Audioclip to play when the key is picked up.
	
	
	public GameObject player1;
	private GameObject player2;
	private GameObject player3;
	private PlayerData playerData;
	Inventory inventory;
	bool inKeyzone;
	
	void Awake ()
	{
		inventory = GameObject.FindGameObjectWithTag ("Inventory").GetComponent<Inventory> ();
		player1 = GameObject.Find ("Player1");

//		player2 = GameObject.Find ("FPSController2");
//		player3 = GameObject.Find ("FPSController3");
	}


	public void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject == player1)
		{
			inKeyzone = true;
		}
	}
	public void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject == player1)
		{
			inKeyzone = false;
		}
	}
	
	void Update()
	{
		
		if(inKeyzone)
		{
			playerData = player1.GetComponent<PlayerData>();
			playerData.hasDrugKey = true;
			if (inventory.checkHasItemInSlot(5,0))
			{
				Debug.Log("Scissors!!!");
//			inventory.removeItem(3,0);
			}
			else {
				Debug.Log("dont point that thing at me");
			}
//			Destroy(gameObject);

		}

//		if(other.gameObject == player2)
//		{
//			playerInventory = player2.GetComponent<PlayerInventory>();
//			playerInventory.hasKey = true;
//			Destroy(gameObject);
//		}
//		if(other.gameObject == player3)
//		{
//			playerInventory = player3.GetComponent<PlayerInventory>();
//			playerInventory.hasKey = true;
//			Destroy(gameObject);
//		}
		
		
		
	}
}