using UnityEngine;

[CreateAssetMenu]
public class TransformController : ScriptableObject
{
    public GameObject objectToTransform;
    public PositionData position;
    public float startingScale = 1.0f;

    public void CreateNewObj(float scaleChange)
    {
        var newObj = Instantiate(objectToTransform, position.positionVector, Quaternion.identity);
        startingScale *= scaleChange;
        newObj.transform.localScale = new Vector3(startingScale, 0.5f, startingScale);
    }

    public void SetStartScale(float newScale)
    {
        startingScale = newScale;
    }
}
