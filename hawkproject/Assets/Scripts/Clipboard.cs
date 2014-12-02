using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clipboard : MonoBehaviour {



//
	Canvas clipboard;

	void Start()
	{
		clipboard = GetComponent<Canvas>();
		clipboard.enabled = false;
	}
////
//
//	//void OnTriggerStay2D(Collider2D other)
//	//{
//	//	Invoke ("ClipboardToggle", 0f);
//	//}
//
//
//
//	//public void ClipboardToggle()
//	//{
//
//	//void Update()
//	//{
//	//	if (Input.GetKeyDown(KeyCode.Tab))
//	//	{
//	//		ClipboardToggle();
//	//	}
//	//}
//	
	public void ClipboardToggle()
	{
		clipboard.enabled = !clipboard.enabled;
		//Time.timeScale = Time.timeScale == 0 ? 1 : 0;
	}



}