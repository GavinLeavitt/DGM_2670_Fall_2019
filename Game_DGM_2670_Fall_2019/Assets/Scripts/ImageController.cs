using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    private Image imageComponent;
    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }
    
    public void UpdateImageComponent(FloatData dataObj)
    {
        imageComponent.fillAmount = dataObj.value;
    }
}