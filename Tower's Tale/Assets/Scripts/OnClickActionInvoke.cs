using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickActionInvoke : MonoBehaviour
{
    public GameAction gameActionObj;
    private void OnMouseDown()
    {
        gameActionObj.Raise();
        Debug.Log("CLICK HAPPEN");
    }
}