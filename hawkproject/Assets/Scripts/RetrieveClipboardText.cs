using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RetrieveClipboardText : MonoBehaviour {

	public BedArea bedarea;

	Text clipboardtext;
	Text currentclipboard;
	public string bedspace = "1";


	void Awake()
	{
		clipboardtext = GetComponent<Text>();
		currentclipboard = bedarea.GetComponent<Text> ();
		bedspace = currentclipboard.text;
	}
	

	void Update (){

		if (bedspace == "1")
		{
			clipboardtext.text = "Patient 1";
		}

		if (bedspace == "2")
		{
			clipboardtext.text = "Patient 2";
		}


		//clipboardtext.text = bedarea.newtext.text;
		
	}

}
