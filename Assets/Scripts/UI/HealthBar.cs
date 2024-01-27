using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float currentValue;

    public float GetCurrentValue()
    {
        return currentValue;
    }

    public void TakingDamage(int damage)
    {
        currentValue -= damage;
    }
}
