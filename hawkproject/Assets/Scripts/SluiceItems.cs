using UnityEngine;
using System.Collections;

public class SluiceItems: MonoBehaviour
{
	
	
	private GameObject player1;
//	private PlayerData playerData;
	Inventory inventory;
	bool collision;
	
	void Awake ()
	{
		inventory = GameObject.FindGameObjectWithTag ("Inventory").GetComponent<Inventory> ();
		player1 = GameObject.Find ("Player1");
	//	playerData = player1.GetComponent<PlayerData>();
	//	player2 = GameObject.Find ("FPSController2");
	//	player3 = GameObject.Find ("FPSController3");
	}
	
	public void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject == player1)
		{
		collision = true;
		}
	}
	
	public void OnTriggerExit2D(Collider2D other){
		if(other.gameObject == player1)
		{
		collision = false;
		}
	}

	void ItemPickup()
	{
		if (Input.GetMouseButtonDown (0) && collision)
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);

			if(hit)
			{
				if (hit.collider.gameObject.name == "Pillow") {
					inventory.addItem(2);
				}
				
				if (hit.collider.gameObject.name == "Scissors") {
					inventory.addItem(5);
				}
				
				if (hit.collider.gameObject.name == "Scalpel") {
					inventory.addItem(3);
				}
				
				if (hit.collider.gameObject.name == "Defibrillator") {
					inventory.addItem(4);
				}
			}
		}
	}


	void Update(){
			ItemPickup ();
		}

}