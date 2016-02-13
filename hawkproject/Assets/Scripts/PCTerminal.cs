using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PCTerminal : MonoBehaviour {

	
	GameObject player;
	bool playerInZone;
	public UIManager uim;


	void Awake ()
	{
		player = GameObject.Find("Player1");
	}
	
	void OpenComputerScreen()
	{
		if (!uim.computerScreen.activeSelf && !uim.medicalPages[0].activeSelf)
		{
			uim.computerScreen.SetActive(true);
		} 
	}

	
	public void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject == player)
		{
			playerInZone = true;
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
			if(Input.GetMouseButtonDown (0)) //&& !medicalRecord.gameObject.activeSelf
			{
				OpenComputerScreen();			
			}
			
		}
	}
	
}
