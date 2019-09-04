using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    private Image imageComponent;
    public UnityEvent UpdateImageEvent;
    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }
    
    private void Update()
    {
        UpdateImageEvent.Invoke();
    }
    
    public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillAmount = dataObj.value;
    }
}