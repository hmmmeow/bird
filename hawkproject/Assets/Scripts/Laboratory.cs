using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Laboratory : MonoBehaviour {
	
	GameObject player;
	bool playerInZone;
	public int bloodAnalysisTimer;
	public Inventory inv;
	public UIManager uim;
	public string allBloodResults;
	
	public List<string> bloodList = new List<string>();
	
	public Queue<GameObject> bloodQueue = new Queue<GameObject>();

	void Awake ()
	{
		player = GameObject.Find("Player1");
		StartCoroutine(AnalyseBlood(0f));
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
	
	void CheckForSamples ()
	{
		if(inv.Items[0].itemName == "Blood")
		{
			bloodQueue.Enqueue(inv.Items[0].itemObj);
//			Debug.Log (inv.Items[0].itemObj.GetComponent<BloodSample>().bloodresult);
//			Debug.Log(inv.Items[0].itemObj + " added to queue");
			inv.Items[0] = new Item();
		}
	}
	
	IEnumerator AnalyseBlood (float delay)
	{
		if(bloodQueue.Count > 0)
		{
			yield return new WaitForSeconds(bloodAnalysisTimer);
			BloodSample bs = bloodQueue.Peek().GetComponent<BloodSample>();
			string analysis = bs.visitorName + " (" + bs.hospitalID + "): " + bs.bloodresult + "\n";
			bloodList.Add (analysis);
			bloodQueue.Dequeue();
			
			allBloodResults = "Blood Results: " + "\n";
			if(bloodList.Count > 10)
			{
				bloodList.Clear();
			}
			for(int i = 0; i < bloodList.Count; i++)
			{
				allBloodResults = allBloodResults + bloodList[i];
			}
			uim.computerScreenText.GetComponent<Text>().text = allBloodResults;
		}
		yield return new WaitForSeconds(delay);
		StartCoroutine(AnalyseBlood(10f));		
	}
	
	
	

	void Update()
	{
		if(playerInZone)
		{
				CheckForSamples();
		}
	}
	
	
}
