using UnityEngine;
using System.Collections;

public class BedSpace : MonoBehaviour
{
	public GameObject[] bedspace;
	string bedSpaceName;

	void Start ()
	{
		bedspace = GameObject.FindGameObjectsWithTag("BedArea");
		
		for(int i = 0; i < bedspace.Length; i++)
		{
			bedSpaceName = bedspace[i].guiText.text;
			bedSpaceName = "Patient " + i;
			bedspace[i].guiText.text = bedSpaceName;
			//print(bedspace[i].name + " has the text: " + bedSpaceName);
			//print(bedspace[i].name + " has the text: " + bedspace[i].guiText.text);
		}
	}
}