using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndgameClass : MonoBehaviour
{
    public GameAction gameActionObj;
    private void OnMouseDown()
    {
        gameActionObj.Raise();
    }
}
