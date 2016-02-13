using UnityEngine;
using System.Collections;

public class PatientTreatment : MonoBehaviour {
	
	PlayerData playerData;
	PatientData pd;
	Inventory inv;
	
	void Awake ()
	{
		playerData = GameObject.Find("Player1").GetComponent<PlayerData>();
		pd = this.gameObject.GetComponent<PatientData> ();
		inv = GameObject.FindGameObjectWithTag ("Inventory").GetComponent<Inventory> ();
	}
	
	public void HasTreatment()
	{

		if (inv.Items[0].itemName == "Pillow")
		{
			pd.health--;
			CheckHealth();
		}
	}
	
	void CheckHealth()
	{
		if(pd.health == 1)
		{
			Debug.Log("Why are you doing this to me?");
		}
		else if(pd.health == 0)
		{
			pd.patientDead = true;
			playerData.harmed++;
			Debug.Log ("RIP me");
		}
	}
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

