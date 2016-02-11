using UnityEngine;
using System.Collections;

public class Item {

	public int itemID;
	public string itemName;
	public string itemDesc;
	public int itemValue;
	public int itemEnergy;
	public int itemReputation;
	public ItemType itemType;

	public Sprite itemIcon;
	public GameObject itemModel;

	public enum ItemType
	{
		Weapon,
		Quest,
		Consumable
	}

	public Item(int id, string name, string desc, int value, int energy, int reputation, ItemType type)
	{
		itemID = id;
		itemName = name;
		itemDesc = desc;
		itemValue = value;
		itemEnergy = energy;
		itemReputation = reputation;
		itemType = type;
		itemIcon = Resources.Load<Sprite> ("" + name);

	}
	public Item(){}



}