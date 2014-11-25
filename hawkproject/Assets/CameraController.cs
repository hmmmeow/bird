using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform character;
	private Vector3 moveTemp;
	float camspeed = 3;
	float xDifference;
	float yDifference;
	float movementThreshold = 1;

	
	void Update () 
	{




		if (character.transform.position.x > transform.position.x)
				{
			xDifference = character.transform.position.x - transform.position.x;
				}
		else
				{
			xDifference = transform.position.x - character.transform.position.x;
				}


		if (character.transform.position.y > transform.position.y)
		{
			yDifference = character.transform.position.y - transform.position.y;
		}
		else
		{
			yDifference = transform.position.y - character.transform.position.y;
		}


		if (xDifference >= movementThreshold || yDifference >= movementThreshold)
			{
			moveTemp = character.transform.position;
			moveTemp.z = -1;
			transform.position = Vector3.MoveTowards (transform.position, moveTemp, camspeed * Time.deltaTime);
						}

	
	}



}


