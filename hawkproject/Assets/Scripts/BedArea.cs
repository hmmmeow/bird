using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BedArea : MonoBehaviour {


	public GameObject clipboardObject;
	public Canvas clipboardCanvas;
	string bedspace;
	bool collision;
	Text clipboardText;
	string patientInformation;
//	Text clipboardtext;

	void Start(){
		clipboardObject = GameObject.FindGameObjectWithTag ("Clipboard");
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

		clipboardCanvas = clipboardObject.GetComponent<Canvas> ();
		clipboardCanvas.enabled = !clipboardCanvas.enabled;

		clipboardText = clipboardCanvas.GetComponentInChildren<Text> ();


		clipboardText.text = getBedSpace();
//		print (clipboardText.text);

		}


	public void OnTriggerEnter2D(Collider2D other){
		collision = true;
		}

	public void OnTriggerExit2D(Collider2D other){
		collision = false;
		}





	void Update(){

				if (Input.GetMouseButtonDown (0) && collision) {
						
						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
						
					if (hit && hit.collider.gameObject.name == "Clipboard"){
//						print ("Clipboard selected");
						ShowClipboard();
					}
									

				}

		}
	
//	if (Input.GetMouseButtonDown (0))
//		{
//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
//						
//			if (hit.collider.gameObject.name == "Clipboard") {
//
//				Invoke("ShowClipboard", 0f);
//
//					} 
//		
//
//		}





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
