using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BedArea : MonoBehaviour {


	//public GameObject clipboard;
	//public Clipboard clipboard;
	//public Canvas clipboardCanvas;
	string bedspace;
//	Text clipboardtext;

	void Start()
	{
		//clipboardCanvas = FindObjectOfType<Canvas> ();
			//GetComponentInParent<Canvas>();
		//clipboardCanvas.enabled = false;
	}

//	string ClipBoardText()
//	{
//		clipboardtext = GetComponent<Text>();
//		return clipboardtext.text;
//	}

//	public void ActivateClipboardToggle()
//	{
//		//clipboardCanvas = FindObjectOfType<Canvas> ();
//		//clipboardCanvas.enabled = !clipboardCanvas.enabled;
//		clipboard.ClipboardToggle ();
//		print (getBedSpace() + " has the text ");
//		//Time.timeScale = Time.timeScale == 0 ? 1 : 0;
//	}


	void ShowClipboard(){

		//clipboard.ClipboardToggle();
		print (getBedSpace());

		}


	public void OnTriggerStay2D(Collider2D other){


	
	if (Input.GetMouseButtonDown (0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
						
			if (hit.collider.gameObject.name == "Clipboard") {

				Invoke("ShowClipboard", 0f);

					} 
		

		}

	}



	public string getBedSpace(){
		string text = guiText.text;
		//PlayerPrefs.SetString ("bedspace", text);
		//text = GetComponent<Text> ();
		//bedspace = text.text;
		return text;
	}




//	void CastRay() {
//		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//		RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
//		
//		string selection = hit.collider.gameObject.name;
//		
//		if (hit && selection == "Clipboard") {
//			print (selection);
//		} else {
//			print ("No clipboard");
//				}
//
//
//	}





}
