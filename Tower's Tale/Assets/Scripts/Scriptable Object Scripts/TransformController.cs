using UnityEngine;

[CreateAssetMenu]
public class TransformController : ScriptableObject
{
    public GameObject objectToTransform;
    public PositionData position;
    private float scale = 1.0f;

    public void CreateNewObj(float scalechange)
    {
        var newObj = Instantiate(objectToTransform, position.positionVector, Quaternion.identity);
        scale *= scalechange;
        newObj.transform.localScale = new Vector3(scale, scale, scale);
    }
}
