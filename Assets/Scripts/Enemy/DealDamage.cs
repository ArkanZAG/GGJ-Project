using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    [SerializeField] private int damage;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != "Player") return;
        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        if (player == null) return;
        player.TakeDamage(damage);
    }
}
