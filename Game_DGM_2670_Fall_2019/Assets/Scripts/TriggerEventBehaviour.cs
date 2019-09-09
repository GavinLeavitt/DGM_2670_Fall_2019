using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }
}
