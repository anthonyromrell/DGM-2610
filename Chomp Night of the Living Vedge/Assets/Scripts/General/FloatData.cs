﻿using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Single Variables/FloatData")]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public float maxValue = 1f;
    public UnityEvent zeroEvent;
    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void UpdateValueLimitZero(float amount)
    {
        if (value > 0)
        {
            UpdateValue(amount);
        }
        else
        {
            value = 0;
            zeroEvent.Invoke();
        }
    }
    
    public void ChangeAmount(float amount)
    {
        value = amount;
    }
}
