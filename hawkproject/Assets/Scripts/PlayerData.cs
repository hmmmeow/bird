using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour {

	public UIManager uim;
	// Player name

	public string playerName = "Doctor";

	// Inventory

	public bool hasDrugKey;
	public bool hasMRSA;
	

	// Data

	public int money = 0;
	public int reputation = 0;
	public int energy = 100;
	
	public int cured = 0;
	public int harmed = 0;
	public int breached = 0;
	public string breachPercent;
	
	void BreachUpdate()
	{		
		if(cured+harmed > 0)
		{
			breachPercent = breached * 100 / (cured + harmed) + "%";
		}
		Invoke ("BreachUpdate",2f);

	}


	// Items

	void Awake ()
	{
		BreachUpdate();		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Escape)) {
			uim.PauseMenu ();
		}

	}


}
