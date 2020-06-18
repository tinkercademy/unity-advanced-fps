﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBase : MonoBehaviour
{
    protected int health;
    public bool Dead()
    {
        return health <= 0;
    }
    public virtual void TakeDamage(int damage)
    {
        if (Dead()) return;
        
        health -= damage;
        
        if (Dead()) Die();
    }
    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
