using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDetectors : MonoBehaviour
{
   public UnityEvent m_PlayerDetected = new UnityEvent();
  
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            m_PlayerDetected.Invoke();
        }
    }

    public void Log()
    {
        Debug.Log("Player Detected");
    }
}
