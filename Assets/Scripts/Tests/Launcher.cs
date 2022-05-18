using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    
    void Start()
    {
        TimeStuff time = new TimeStuff();

        time.Hours = 24;
        Debug.Log("Time: " + time.Hours);

        TimeStuff time2 = new TimeStuff();
        time2.Hours = time.Hours + 5;

        TimeStuff stringtime = new TimeStuff();
        stringtime.Test = "test";
        Debug.Log("Time: " + time.Hours + " | Time2: " + time2.Hours+" ||  " + stringtime.Test);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
