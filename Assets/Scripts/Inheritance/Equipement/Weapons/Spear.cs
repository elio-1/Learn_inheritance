using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Spear", menuName = "Item/Equipement/Weapon/Spear")]
public class Spear : Weapon
{
    public override void Attack()
    {
        Debug.Log("Spear Strike!");
    }
}
