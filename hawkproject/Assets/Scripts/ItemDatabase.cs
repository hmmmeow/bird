using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

	public List<Item> items = new List<Item>();


	// Use this for initialization
	void Start () {
		items.Add (new Item (0, "Potion", "Vitalise your energy", 20, 10, 0, Item.ItemType.Consumable));
		items.Add (new Item (1, "PotionPlus", "Max your energy", 80, 100, 0, Item.ItemType.Consumable));
		items.Add (new Item (2, "Pillow", "Soft head cushion. Do not inhale.", 0, 0, -5, Item.ItemType.Weapon));
		items.Add (new Item (3, "Scalpel", "Precise cutting instrument. Sharp.", 0, 0, -20, Item.ItemType.Weapon));
		items.Add (new Item (4, "Defibrillator", "Delivers high voltage. Shocking.", 0, 0, -10, Item.ItemType.Weapon));
		items.Add (new Item (5, "Scissors", "Pair of blades. Do not run with.", 0, 0, -20, Item.ItemType.Weapon));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
