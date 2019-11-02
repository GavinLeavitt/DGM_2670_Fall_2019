using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int Value = 0;
    public int MaxValue = 3;

    public void AddValue(int valueToAdd)
    {
        if (Value < MaxValue)
        {
            Value += valueToAdd;
        }
    }

    public void SetValue(int valueToSet)
    {
        Value = valueToSet;
    }
}
