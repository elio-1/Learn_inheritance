using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : Equipement
{
    public int m_damage;
    public abstract void Attack();
}
