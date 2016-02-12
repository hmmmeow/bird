using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {


	public List<GameObject> Slots = new List<GameObject> ();
	public List<Item> Items = new List<Item> ();
	public GameObject slots;
	ItemDatabase db;
	int hotkey;
//	UIManager uim;
//	int x = -160;
	int slotCount = 1;
//	int x = 0;
//	int y = 0;

	void CreateHotbar()
	{
		int x = (-slotCount + 1) * 40;
		int slotAmount = 0;
//		for (int i = 0; i < 1; i++)
//		{}
		for(int k = 0; k < slotCount; k++)
		{
			GameObject slot = (GameObject)Instantiate(slots);
			Slots.Add(slot);
			Items.Add(new Item());
			slot.transform.SetParent(this.gameObject.transform, false);
			slot.name = "Slot" + k;
			slot.GetComponent<RectTransform>().localPosition = new Vector3(x,0,0);
			slot.GetComponent<SlotManager>().slotNumber = slotAmount;
			x = x + 80;
			slotAmount++;
		}
	}



	// Use this for initialization
	void Awake ()
		{
			db = GameObject.FindGameObjectWithTag ("ItemDatabase").GetComponent<ItemDatabase>();
//			uim = GameObject.FindGameObjectWithTag ("UIManager").GetComponent<UIManager>();
			CreateHotbar ();
			addItem (0);

//			Debug.Log (Items[0].itemName);
//			
		}

	void Update()
	{
//		removeItem (0,1);
//		Debug.Log (hotkey);
			
	}

	public void HotkeyPress()
	{
		if(Input.GetKeyDown(KeyCode.Alpha1)){hotkey = 1;}
		if(Input.GetKeyDown(KeyCode.Alpha2)){hotkey = 2;}
		if(Input.GetKeyDown(KeyCode.Alpha3)){hotkey = 3;}
		if(Input.GetKeyDown(KeyCode.Alpha4)){hotkey = 4;}
		if(Input.GetKeyDown(KeyCode.Alpha5)){hotkey = 5;}
		if(Input.GetKeyDown(KeyCode.Alpha6)){hotkey = 6;}
		if(Input.GetKeyDown(KeyCode.Alpha7)){hotkey = 7;}
		if(Input.GetKeyDown(KeyCode.Alpha8)){hotkey = 8;}
		if(Input.GetKeyDown(KeyCode.Alpha9)){hotkey = 9;}
	}

	public void removeItem(int itemid, int keypressed)
	{
		HotkeyPress ();
		keypressed = hotkey;
		if(hotkey != 0)
		{
		keypressed = hotkey;
		int h = keypressed - 1;
		if (Items [h].itemID == itemid)
			{
				Items [h] = new Item ();
				hotkey = 0;
			} 
		}

	}

	public bool checkHasItemInSlot (int itemid, int keypressed)
	{

		HotkeyPress ();
		keypressed = hotkey;
		if(hotkey != 0)
		{
		keypressed = hotkey;
		int h = keypressed - 1;		
		if (Items [h].itemID == itemid) {
						return true;
				} else {
						return false;
				}
		}else{ return false;}

	}

	public bool checkHasItem (int itemid)
	{
		for (int i = 0; i < Items.Count; i++)
		{
			if (Items [i].itemID == itemid)
			{
				return true;
			}

		}
		return false;
		
	}


	public void addItem(int itemid)
	{
		for (int i = 0; i < db.items.Count; i++)
		{
			if(db.items[i].itemID == itemid)
			{
				Item item = db.items[i];
				addItemIfEmpty(item);
				break;
			}
		}
	}


	public void addItemIfEmpty(Item item)
	{
		for (int k = 0; k < Items.Count; k++)
		{
			if(Items[k].itemName == null)
			{
				Items[k] = item;
				break;
			}
		}
	}

	

}
