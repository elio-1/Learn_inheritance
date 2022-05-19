using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sword", menuName = "Item/Equipement/Weapon/Sword")]
public class Sword : Weapon
{
    public override void Attack()
    {
        Debug.Log("Sword Strike!");
    }
}
