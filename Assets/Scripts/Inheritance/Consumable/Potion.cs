using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Potion", menuName = "Item/Consumable/Potion")]

public class Potion : Consumable
{
    public int m_points;
    public override void Use()
    {
        Debug.Log("Used "+m_name+", heal for: " + m_points);
    }
}
