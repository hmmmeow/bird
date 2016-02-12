using UnityEngine;
using System.Collections;

public class PatientInvestigations : MonoBehaviour {

	PatientData pd;
	Inventory inv;
	public GameObject bloodsamplePrefab;
	
	void Awake ()
	{
		pd = this.gameObject.GetComponent<PatientData> ();
		inv = GameObject.FindGameObjectWithTag ("Inventory").GetComponent<Inventory> ();
	}
	
	public void TakeBlood()
	{
		if (inv.checkHasItem(6))
		{
				//				inventory.removeItem(6,1);
			
			inv.Items[0] = new Item (); //set hotbar slot 0 to empty
			
			GameObject bloodGameobject = (GameObject)Instantiate(bloodsamplePrefab);
			bloodGameobject.transform.SetParent(this.gameObject.transform, false);
			bloodGameobject.name = "BloodSample" + pd.visitorNumber;
			Item item = new Item(-1, "Blood", "Some thick red stuff.", pd.visitorNumber, Item.ItemType.blood, bloodGameobject);
			
			inv.Items[0] = item;
			
			//				inventory.addItemIfEmpty(item);
			
			BloodSample bs = bloodGameobject.GetComponent<BloodSample>();
			bs.visitorID = pd.visitorNumber;
			bs.visitorName = pd.patientName;
			bs.hospitalID = pd.patientHospitalNumber;
			bs.bloodresult = pd.patientBlood;
			bs.itemdata = item;
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
