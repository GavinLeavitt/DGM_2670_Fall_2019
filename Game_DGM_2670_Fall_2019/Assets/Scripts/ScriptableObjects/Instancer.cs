using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameAction gameActionObj;
    
    public Vector3 instanceAtLocation;
    
    public void InstanceObj(GameObject obj)
    {
        var newObj = Instantiate(obj, instanceAtLocation, Quaternion.identity);
        gameActionObj.transformAction(newObj.transform);
    }
}
