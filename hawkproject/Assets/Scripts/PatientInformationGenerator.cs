using UnityEngine;
using System.Collections;

public class PatientInformationGenerator : MonoBehaviour
{
	public PatientCatalogue patient;
	public GameObject[] bedspace;
	string patientBio;
	string patientDiagnosis;
	string patientSymptoms;


	void Start ()
	{
		bedspace = GameObject.FindGameObjectsWithTag("BedArea");
		
		for(int i = 0; i < bedspace.Length; i++)
		{
//			patientBio = bedspace[i].guiText.text;

			patientBio = "Name: " + patient.getRandomFullName() + "\nAge: " + patient.getRandomAge();

//			patientSymptoms = "Main symptom: " + patient.getAssociatedSymptoms();

			patientDiagnosis = "Main diagnosis: " + patient.getRandomDiagnosis();

			bedspace[i].guiText.text = patientBio + "\n" + patientDiagnosis;
//			bedspace[i].guiText.text = patientBio + "\n" + patientSymptoms + "\n" + patientDiagnosis;
			//print(bedspace[i].name + " has the text: " + bedSpaceName);
			//print(bedspace[i].name + " has the text: " + bedspace[i].guiText.text);
		}
	}
}