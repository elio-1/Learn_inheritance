using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Antidote", menuName = "Item/Consumable/Antidote")]

public class Antidote : Consumable
{
    public override void Use()
    {
        Debug.Log("Used " + m_name );
    }
}
