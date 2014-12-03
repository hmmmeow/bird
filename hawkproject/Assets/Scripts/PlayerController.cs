using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	void FixedUpdate()
	{
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.back);
		transform.rotation = rot;

		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);

//		rigidbody2D.angularVelocity = 0;

				
	
	}


	void Update()
	{
		transform.Translate(-Vector2.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed, Space.Self);
		transform.Translate(-Vector2.up * Input.GetAxis("Vertical") * Time.deltaTime * speed, Space.Self);
	}



}
