using UnityEngine;
using System.Collections;

public class ClickClipboard : MonoBehaviour {


	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			print("Pressed left click, casting ray.");
			CastRay();
		}       
	}
	
	void CastRay() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);

		string selection = hit.collider.gameObject.name;

		if (hit && selection == "Clipboard")
		{
			print (selection);
		}

		//if (hit) {
		//	print (hit.collider.gameObject.name);
		//}
	}



}