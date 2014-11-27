using UnityEngine;
using System.Collections;


public class BedArea : MonoBehaviour {


	public Clipboard clipboard;

	void OnTriggerStay2D(Collider2D other)
	{
		Invoke ("ShowClipboardNow", 0f);
	}

	void ShowClipboardNow()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			clipboard.ClipboardToggle();
		}
	}


}
