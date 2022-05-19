using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Axe", menuName = "Item/Equipement/Weapon/Axe")]

public class Axe : Weapon
{
    public override void Attack()
    {
        Debug.Log("Axe Strike!");
    }
}
