using UnityEngine;
using System.Collections;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class LoadOnClick : MonoBehaviour {
	
	public GameObject loadingImage;
	
	public void LoadScene(int level) //1
	{
		loadingImage.SetActive(true);
		Application.LoadLevel(level);
	}

	public void LoadOptions(int level) //2
	{
		loadingImage.SetActive(true);
		Application.LoadLevel(level);
	}

	public void Quit()
	{
		#if UNITY_EDITOR 
		EditorApplication.isPlaying = false;
		#else 
		Application.Quit();
		#endif
	}
}