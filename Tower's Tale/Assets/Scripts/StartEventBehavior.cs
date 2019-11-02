using UnityEngine;
using UnityEngine.Events;

public class StartEventBehavior : MonoBehaviour
{
    public UnityEvent StartEvent;
    
    private void Start()
    {
        StartEvent.Invoke();
    }
}