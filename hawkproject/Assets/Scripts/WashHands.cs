using UnityEngine;
using System.Collections;

public class WashHands : MonoBehaviour
{

	
	private GameObject player1;
	private PlayerData playerData;   
	
	void Awake ()
	{
		player1 = GameObject.Find ("Player1");
		//		player2 = GameObject.Find ("FPSController2");
		//		player3 = GameObject.Find ("FPSController3");
	}
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		
		if(other.gameObject == player1)
		{
			playerData = player1.GetComponent<PlayerData>();
			playerData.hasMRSA = false;
		//	Destroy(gameObject);

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