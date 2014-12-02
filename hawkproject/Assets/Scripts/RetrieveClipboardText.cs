using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RetrieveClipboardText : MonoBehaviour {

	public BedArea bedarea;
	Text clipboardtext;
	string bedNumber = "0";





//	void Update()
//	{
//		print (BedAreaNumber ());
//	}

	string ClipBoardText()
	{
		clipboardtext = GetComponent<Text>();
		return clipboardtext.text;
	}

	public void BedSpaceNumber (){

		//bedNumber = bedarea.getBedSpace();
							
		}

//	void Start(){
//		BedSpaceNumber ();
//		print (bedNumber);
//		
//	}

//	void Update (){
//
//		print (BedSpaceNumber ());

//		if (bedNumber != null) {
//
//				if (Input.GetKeyDown (KeyCode.Tab)) {
//					print (bedNumber + " success");
//				} 
//
//				}
			

//		if (bedNumber == "null") {
//			return;
//				}
//
//		if (bedNumber == "1") {
//			print ("Patient 1 information goes here");
		

//ClipBoardText ();

				


//		if BedAreaNumber() = "1"
//		{
//			clipboardtext.text = "Patient 1";
//
//		}



}
