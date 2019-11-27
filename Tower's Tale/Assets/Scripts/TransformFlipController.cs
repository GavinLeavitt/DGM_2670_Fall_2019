using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class TransformFlipController : MonoBehaviour
{
    public PositionData destinationPosition;
    public Transform transformObj;
    public float rotationSpeed = 0.0f;
    private float orientation = 1.0f;

    private void Start()
    {
        transformObj = GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            orientation = Mathf.Sign(destinationPosition.positionVector.x - transformObj.transform.position.x);
            var newOrientation = (180.0f + (orientation*180.0f))/2.0f;
            //Debug.Log(newOrientation);
            if (newOrientation != transformObj.transform.eulerAngles.y)
            {
                if (newOrientation == 0.0f && transformObj.transform.eulerAngles.y == 180.0f)
                {
                    StartCoroutine("FlipLeft");
                } else if (newOrientation == 180.0f && transformObj.transform.eulerAngles.y == 0.0f)
                {
                    StartCoroutine("FlipRight");
                }
            }
        }
    }

    IEnumerator FlipRight()
    {
        for (float i = 0.0f; i < 181.0f/rotationSpeed; i++)
        {
            transformObj.transform.eulerAngles = new Vector3(0, i*rotationSpeed, 0);
            yield return null;
        }
    }

    IEnumerator FlipLeft()
    {
        for (float i = 180.0f/rotationSpeed; i > 0.0f; i--)
        {
            transformObj.transform.eulerAngles = new Vector3(0, (i*rotationSpeed)-rotationSpeed, 0);
            yield return null;
        }
    }
}