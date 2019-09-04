using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public float maxValue = 1f;
    public float minValue = 0f;
    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void UpdateValueClamped(float amount)
    {
        value = Mathf.Clamp(value+amount, minValue, maxValue);
    }
}