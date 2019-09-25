using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMousePositionOnClick : MonoBehaviour
{
    public Camera cam;
    public PositionData playerPosition;

    private void OnMouseDown()
    {
        RaycastHit hit;
        Ray testRay = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(testRay, out hit))
        {
            playerPosition.positionVector = hit.point;
            playerPosition.positionVector.y = 0.5f;
        }
    }
}