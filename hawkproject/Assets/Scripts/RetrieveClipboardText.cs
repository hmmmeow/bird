using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RetrieveClipboardText : MonoBehaviour {

	Text clipboardtext;

	public string bedspace = "0";


	void Awake()
	{
		clipboardtext = GetComponent<Text>();
		//bedspace = PlayerPrefs.GetString("bedspace");
	}
	

	void Update (){

		bedspace = PlayerPrefs.GetString("bedspace");


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
