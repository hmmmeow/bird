using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

	public List<Item> items = new List<Item>();
	public GameObject empty;


	// Use this for initialization
	void Start () {
		items.Add (new Item (0, "Potion", "Vitalise your energy", -1, empty));
		items.Add (new Item (1, "PotionPlus", "Max your energy", -1, empty));
		items.Add (new Item (2, "Pillow", "Soft head cushion. Do not inhale.", -1, empty));
		items.Add (new Item (3, "Scalpel", "Precise cutting instrument. Sharp.", -1, empty));
		items.Add (new Item (4, "Defibrillator", "Delivers high voltage. Shocking.", -1, empty));
		items.Add (new Item (5, "Scissors", "Pair of blades. Do not run with.", -1, empty));
		items.Add (new Item (6, "Syringe", "Fluid not included.", -1, empty));
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
