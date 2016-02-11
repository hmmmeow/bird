using UnityEngine;
using System.Collections;

public class Matron : MonoBehaviour {


//	GameObject matron;
	public Vector3 matronT;
	public int speed = 1;
	public string direction = "right";
	GameObject player;
	Inventory inventory;
	bool matronSeesYou;
	bool move;


	public void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject == player)
		{
		matronSeesYou = true;
		}

	}
	public void OnTriggerExit2D(Collider2D other){matronSeesYou = false;}

	void MatronSeesYou()
	{
		if(matronSeesYou)
		{
			if (inventory.checkHasItem(5))
				{
					Debug.Log("Scissors detected");
					move = false;
					//			inventory.removeItem(3,0);
				}
		}else
		{
			move = true;
		}
	}

	void MatronMovement()
	{
		if(move)
		{
			if(transform.position.x < 10 && direction == "right")
			{
				transform.Translate(Vector2.down * speed * Time.fixedDeltaTime);
				transform.rotation = Quaternion.Euler(0f, 0f, 90);
			}
			if(transform.position.x >= 10 && direction == "right")
			{
				direction = "left";
			}
			if(transform.position.x > -10 && direction == "left")
			{
				transform.Translate(Vector2.down * speed * Time.fixedDeltaTime);
				transform.rotation = Quaternion.Euler(0f, 0f, 270);
			}
			if(transform.position.x <= -10 && direction == "left")
			{
				direction = "right";
			}
		}
		//		for(int i = 0; i < 120; i++) {
//			matronT = this.gameObject.transform.localPosition;
//			matronT = new Vector3(i, 0, 90);
//
		//			transform.Translate(-Vector2.right * Time.deltaTime * speed, Space.Self);

	}






	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player1");
		inventory = GameObject.FindGameObjectWithTag ("Inventory").GetComponent<Inventory> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		MatronMovement ();
		MatronSeesYou ();
	}
}
