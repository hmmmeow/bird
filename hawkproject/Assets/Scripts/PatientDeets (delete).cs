using UnityEngine;
using System.Collections;

public class PatientDeets {

	public int visitorNumber;
	public string patientFullName;
	public string patientDisNumber;
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
	
	public PatientDeets(int id, string name, string dis, int value, int energy, int reputation, ItemType type)
	{
		visitorNumber = id;
		patientFullName = name;
		patientDisNumber = dis;
		itemValue = value;
		itemEnergy = energy;
		itemReputation = reputation;
		itemType = type;
		itemIcon = Resources.Load<Sprite> ("" + name);
		
	}
	public PatientDeets(){}
	
}
