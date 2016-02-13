using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

#if UNITY_EDITOR
using UnityEditor;
#endif


public class UIManager : MonoBehaviour {
	
	public List<GameObject> medicalPages = new List<GameObject> ();
	public GameObject[] stickyLabels;
//	public List<GameObject> medicalLabels = new List<GameObject> ();
	public GameObject currentTreatmentLabel;
	public GameObject computerScreen;
	public GameObject computerScreenText;
	
//	PatientData patientData;

	GameObject medicalRecord;
	GameObject biographicsPages;
	GameObject diagnosticsPages;
	GameObject treatmentPages;
	GameObject pauseMenu;
	
	
	void Start()
	{
		
//		StickyLabelArray();
		stickyLabels = GameObject.FindGameObjectsWithTag("StickyLabel");
		
		biographicsPages = GameObject.Find ("BiographicsPages");
		diagnosticsPages = GameObject.Find ("DiagnosticsPages");
		treatmentPages = GameObject.Find ("TreatmentPages");
		medicalRecord = GameObject.Find ("MedicalRecord");
		pauseMenu = GameObject.Find ("PauseMenu");
		
		medicalPages.Add (medicalRecord);
		medicalPages.Add (biographicsPages);
		medicalPages.Add (diagnosticsPages);
		medicalPages.Add (treatmentPages);

		medicalPages[0].SetActive(false);
		medicalPages[1].SetActive(false);
		medicalPages[2].SetActive(false);
		medicalPages[3].SetActive(false);

		computerScreen.SetActive(false);
		pauseMenu.SetActive (false);
		
	}
	
//	void StickyLabelArray()
//	{
//		stickyLabels = GameObject.FindGameObjectsWithTag("StickyLabel");
//		Debug.Log(stickyLabels[0]);
//		foreach(GameObject obj in stickyLabels)
//		{
//			medicalLabels.Add(obj);
//		}
//	}
//	
	
	public void RedX()
	{
		if (medicalPages[0].activeSelf)
		{
			medicalPages[0].SetActive(false);
			medicalPages[1].SetActive(false);
			medicalPages[2].SetActive(false);
			medicalPages[3].SetActive(false);
		} 

	}
	
	public void CloseComputer()
	{
		if (computerScreen.activeSelf)
		{
			computerScreen.SetActive(false);
		} 
		
	}
	
	public void BiographicsPanel()
	{
		if (medicalPages[1].activeSelf){CloseAllPages();}
		else{
		CloseAllPages();
		medicalPages[1].SetActive(true);
		}
	}

	public void DiagnosticsPages()
	{
		if (medicalPages[2].activeSelf){CloseAllPages();}
		else{
			CloseAllPages();
			medicalPages[2].SetActive(true);
		}
	}

	public void TreatmentPages()
	{
		if (medicalPages[3].activeSelf){CloseAllPages();}
		else{
			CloseAllPages();
			medicalPages[3].SetActive(true);
		}
	}
	
	
//	public void TreatmentPages()
//	{
//				if (!medicalPages[3].gameObject.activeSelf)
//				{
//					CloseAllPages();
//					medicalPages[3].SetActive(true);
//				}
//				else
//				{
//					medicalPages[3].SetActive(false);
//				}
//	}


	public void PauseMenu()
	{
			if (!pauseMenu.gameObject.activeSelf)
			{
				pauseMenu.SetActive (true);
				Time.timeScale = Time.timeScale == 0 ? 1 : 0;
			}
			else
			{
				pauseMenu.SetActive (false);
				Time.timeScale = Time.timeScale == 0 ? 1 : 0;
			}
	}

	void CloseAllPages()
	{
		medicalPages[1].SetActive(false);
		medicalPages[2].SetActive(false);
		medicalPages[3].SetActive(false);
	}



	void Update()
		{
//			HotkeyPress ();
		}
//
//		if (Input.GetMouseButtonDown (0) &&  bedZone.BedAreaCheck() && !medicalRecord.gameObject.activeSelf) {
//
//			Debug.Log("Yay");
//		//	OpenMedicalRecord();
//			
//		}



	
	public void QuitGame()
	{
		#if UNITY_EDITOR 
		EditorApplication.isPlaying = false;
		#endif
		//		Application.Quit();
	}
	
}