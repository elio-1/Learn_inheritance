using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Revive", menuName = "Item/Consumable/Revive")]

public class Revive : Consumable
{
    public override void Use()
    {
        Debug.Log("Used " + m_name );
    }
}
