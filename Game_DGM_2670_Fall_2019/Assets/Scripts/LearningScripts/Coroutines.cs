using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    private WaitForSeconds wfs;
    public float holdTime = 0.1f;
    
    private void Awake()
    {
        wfs = new WaitForSeconds(holdTime);
    }
    private IEnumerator Start()
    {
        while (true)
        {
            transform.position += Vector3.right;
            yield return wfs;
        }
    }
}