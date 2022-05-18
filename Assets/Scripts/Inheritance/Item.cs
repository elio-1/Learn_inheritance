using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Item : ScriptableObject
{
    protected int _id;
    public string m_name;
    public Texture2D m_icon;
}
