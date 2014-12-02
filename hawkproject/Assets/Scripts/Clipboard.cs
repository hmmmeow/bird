using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clipboard : MonoBehaviour {

	Canvas clipboardCanvas;

	void Start()
	{
		clipboardCanvas = GetComponent<Canvas>();
		clipboardCanvas.enabled = false;
	}

	public void ClipboardToggle()
	{
		clipboardCanvas.enabled = !clipboardCanvas.enabled;
//		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
	}



}