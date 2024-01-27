using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public int damage;
    [SerializeField] private PlayerHealth playerHealth;
    // public void TakeDamage(int amount)
    // {

    // }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("test");
        if (other.gameObject.tag != "Player") return;
            Debug.Log("test");
            playerHealth.TakeDamage(damage);
            
        
        
    }
}
