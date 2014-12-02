using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BedAreaColliderZone : MonoBehaviour {


	GameObject clipboardObject;
	Canvas clipboardCanvas;
	string bedspace;
	bool collision;
	Text clipboardText;


	void Start(){
		clipboardObject = GameObject.FindGameObjectWithTag ("Clipboard");
	}


	public string getBedSpace(){
		string text = guiText.text;
		return text;
	}

	void ShowClipboard(){

		clipboardCanvas = clipboardObject.GetComponent<Canvas> ();
		clipboardCanvas.enabled = !clipboardCanvas.enabled;

		clipboardText = clipboardCanvas.GetComponentInChildren<Text> ();

		clipboardText.text = getBedSpace();

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
					ShowClipboard();
				}
									
			}

		}
	


}
