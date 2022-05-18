using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStuff
{
    private float _seconds;

    public float Hours
    {
        get { return _seconds / 3600; }
        set { _seconds = value * 3600; }
    }

    private string _string;
    public string Test
    {
        get { return _string; }
        set { _string = value; }
    }
}
