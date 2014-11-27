using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//use playerprefs for bed space??


public class BedArea : MonoBehaviour {

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


	void OnTriggerStay2D(Collider2D other)
	{
		Invoke ("ShowClipboardNow", 0f);
		text = GetComponent<Text> ();
		bedspace = text.text;
		PlayerPrefs.SetString ("bedspace", bedspace);
		//print ("yes");

	//	Invoke ("NewText", 0f);
	}


	//public void NewText()
	//{
	//	newtext = GetComponent<Text>();
	//}


	void ShowClipboardNow()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			clipboard.ClipboardToggle();
		}
	}




}
