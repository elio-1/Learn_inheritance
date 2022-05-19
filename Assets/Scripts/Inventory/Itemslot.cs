using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Itemslot : MonoBehaviour
{ 
    public void Initialize(string itemname, Sprite sprite)
    {
        GetComponentInChildren<TextMeshProUGUI>().text = itemname;
        GetComponentInChildren<Image>().sprite = sprite;
    }
    public void Initialize(Item item)
    {
        GetComponentInChildren<TextMeshProUGUI>().text = item.m_name;
        GetComponentInChildren<Image>().sprite = item.m_icon;
    }
}
