using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
   static List<Item> _itemList = new List<Item>();



    public void AddItem(Item item)
    {
        _itemList.Add(item);
        Debug.Log(item + "added to intentory");
    }

    public void RemoveItem(Item item)
    {
        _itemList.Remove(item);
    }

    public void LogInventory()
    {
        foreach (Item item in _itemList)
        {
            Debug.Log(item);
        }
    }
}
