using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BedArea : MonoBehaviour {


	public Clipboard clipboard;
	string bedspace;
	Text text;



	public void OnTriggerStay2D(Collider2D other)
	{
	
	if (Input.GetKeyDown (KeyCode.Tab))
		{
			ShowClipboardNow();
		}
	
	if (Input.GetMouseButtonDown (0))
		{

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
			
			if (hit && hit.collider.gameObject.name == "Clipboard") {
				ShowClipboardNow();

			} 
		

		}

	}

	public string getBedSpace(){
		text = GetComponent<Text> ();
		bedspace = text.text;
		return bedspace;
	}



	void ShowClipboardNow()
	{
		clipboard.ClipboardToggle();
//		print (getBedSpace());

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

		

	}





}
