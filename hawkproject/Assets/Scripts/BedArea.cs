using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//use playerprefs for bed space??


public class BedArea : MonoBehaviour {

	//public static BedArea bed;

	public Clipboard clipboard;
	public string bedspace = "0";
	Text text;

	//public Text newtext;

	//public string clipboardtext;
	//Text currenttext;
	//void Awake()
	//	{
	//	text = GetComponent<Text>();
	//	}
	//void Update (){
	//	clipboardtext = currenttext.text;
	//	print (clipboardtext);
	//	}


	public void OnTriggerStay2D(Collider2D other)
	{

	if (Input.GetKeyDown (KeyCode.Tab))
		{
			Invoke ("ShowClipboardNow", 0f);
		}
	
	if (Input.GetMouseButtonDown (0))
		{
			//CastRay ();
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
			
			if (hit && hit.collider.gameObject.name == "Clipboard") {
				Invoke ("ShowClipboardNow", 0f);
				//print ("Hit");
			} 
			//else {
			//	print ("No hit");
			//}

		}


		text = GetComponent<Text> ();
		bedspace = text.text;
		PlayerPrefs.SetString ("bedspace", bedspace);

	}


	//public void NewText()
	//{
	//	newtext = GetComponent<Text>();
	//}


	void ShowClipboardNow()
	{
		//if (Input.GetKeyDown(KeyCode.Tab))
		//{
			clipboard.ClipboardToggle();
		//}
	}



	void CastRay() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
		
		string selection = hit.collider.gameObject.name;
		
		if (hit && selection == "Clipboard") {
			print (selection);
		} else {
			print ("No clipboard");
				}

		
		//if (hit) {
		//	print (hit.collider.gameObject.name);
		//}
	}


	//void Update () {
	//	if (Input.GetMouseButtonDown(0)) {
			//print("Pressed left click, casting ray.");
	//		CastRay();
	//	}       
	//}


}
