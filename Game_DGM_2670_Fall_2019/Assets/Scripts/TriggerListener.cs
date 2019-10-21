using UnityEngine;
using UnityEngine.Events;

public class TriggerListener : MonoBehaviour, IListen
{
    public UnityEvent Event { get; set; }
    public Object IRunObj;
    public IRun NewIRunObj { get; set; }
    public void Start()
    {
        Event = new UnityEvent();
        NewIRunObj = IRunObj as IRun;
        if (NewIRunObj != null) Event.AddListener(NewIRunObj.Run);
    }

    private void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
        Event.RemoveListener(NewIRunObj.Run);
    }
}
