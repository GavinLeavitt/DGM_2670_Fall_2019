using UnityEngine;
using UnityEngine.Events;

public class UpdateEvent : MonoBehaviour
{
    public UnityEvent onUpdateEvent;

    private void Update()
    {
        onUpdateEvent.Invoke();
    }
}