using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;


	void FixedUpdate()
	{
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.forward);
		transform.rotation = rot;

		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z-180);
		rigidbody2D.angularVelocity = 0;

		//if (Input.GetKey (KeyCode.S)) {
		//				rigidbody2D.AddForce (gameObject.transform.up * speed);
		//		}
		//if (Input.GetKey (KeyCode.W)) {
		//	rigidbody2D.AddForce (-gameObject.transform.up * speed);
		//}

		//if (Input.GetKey (KeyCode.W)) {
		//	rigidbody2D.AddForce (gameObject.transform.up);
		//}

		//if (Input.GetKey (KeyCode.A)) {
		//	rigidbody2D.AddForce
		//	rigidbody2D.AddForceAtPosition (gameObject.transform.up, gameObject.transform.position.z+1);
		//}


		//if (Input.GetKey (KeyCode.D)) {
		//	player.transform.position = new Vector3 (player.transform.position.x + speed, player.transform.position.y, player.transform.position.z);
		//}

		//if (Input.GetKey (KeyCode.A)) {
		//	player.transform.position = new Vector3 (player.transform.position.x - speed, player.transform.position.y, player.transform.position.z);
		//}

		//if (Input.GetKey (KeyCode.W)) {
		//	player.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y + speed, player.transform.position.z);
		//}

		//if (Input.GetKey (KeyCode.S)) {
		//	player.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y - speed, player.transform.position.z);
		//}
			
	
	}

	void Update()
	{
		transform.Translate(-Vector2.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed, Space.Self);
		transform.Translate(-Vector2.up * Input.GetAxis("Vertical") * Time.deltaTime * speed, Space.Self);
	}




}
