using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTest
{
    private int _id;
    private string _name;

    public MonsterTest()
    {

    }
    public MonsterTest(int id) => this.ID= id;

    public MonsterTest(int id, string name)
    {
        this.ID = id;
        this._name = name;
    }
    public int ID 
    { 
        get => _id;
        set
        {
            Debug.Log("Hello from the ID setter in MonsterTest");
            _id = value;
        }
    }
}
