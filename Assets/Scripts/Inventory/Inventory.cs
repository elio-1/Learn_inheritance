using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> m_itemList = new List<Item>();

    public GameObject _prefabs;

    private void Awake()
    {
        CreateInventory();
    }
    private void Update()
    {

    }


    public void CreateInventory()
    {
        foreach (Item item in m_itemList)
        {
            GameObject itemSlot = Instantiate(_prefabs);
            itemSlot.GetComponent<Itemslot>().Initialize(item);
            itemSlot.transform.SetParent(transform);
            if (item is Armor)
            {
                Debug.Log("this " + item.m_name + "is an armor.");
            }
        }
    }
    public void AddItem(Item item)
    {
        m_itemList.Add(item);
        Debug.Log(item + "added to intentory");
    }

    public void RemoveItem(Item item)
    {
        m_itemList.Remove(item);
    }

    public void LogInventory()
    {
        foreach (Item item in m_itemList)
        {
            Debug.Log(item);
        }
    }
}
