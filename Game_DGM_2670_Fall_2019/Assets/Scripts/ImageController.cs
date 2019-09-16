using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    public UnityEvent startEvent;
    private Image imageComponent;
    private void Start()
    {
        imageComponent = GetComponent<Image>();
        startEvent.Invoke();
    }
    
    public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillAmount = dataObj.value;
    }
}