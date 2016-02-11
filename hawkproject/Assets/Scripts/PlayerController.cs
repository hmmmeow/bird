using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float fixationSpeed;


	void FixedUpdate()
	{
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
//		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.back);
//		transform.rotation = rot;

//		Quaternion playerRotation = Quaternion.LookRotation (mousePosition - transform.position, Vector3.forward);
//		transform.rotation = Quaternion.Slerp (transform.rotation, playerRotation, Time.deltaTime * dampening);
		Vector3 deltaPosition = (mousePosition - transform.position);  
		float atan2 = Mathf.Atan2 (deltaPosition.y, deltaPosition.x);
		transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg + 90), fixationSpeed);

	
//		transform.rotation.y = playerRotation.y;
		                                      //		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
//		rigidbody2D.angularVelocity = 0;

				
	
	}


	void Update()
	{
		transform.Translate(-Vector2.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed, Space.Self);
		transform.Translate(-Vector2.up * Input.GetAxis("Vertical") * Time.deltaTime * speed, Space.Self);
	}



}
