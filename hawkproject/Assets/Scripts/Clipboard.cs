using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clipboard : MonoBehaviour {

	//public Transform bedArea;

	//Canvas clipboard;
	
	//void Start()
	//{
	//	clipboard = GetComponent<Canvas>();
	//	clipboard.enabled = false;
	//}


	void OnTriggerStay2D(Collider2D other)
	{
		Invoke ("ClipboardToggle", 0f);
	}



	public void ClipboardToggle()
	{

		//if (Input.GetKeyDown(KeyCode.Tab))
		//{
		print ("works");	
		//clipboard.enabled = !clipboard.enabled;
		//}

		//clipboard.enabled = !clipboard.enabled;
		//Time.timeScale = Time.timeScale == 0 ? 1 : 0;
	}



}
