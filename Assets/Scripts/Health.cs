﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] private float health = 100;
    [SerializeField] private GameObject deathEffects;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathEffects) {return;}
        GameObject deathVFXObject = Instantiate(deathEffects, transform.position, Quaternion.identity);
        Destroy(deathVFXObject, 5f);
    }

    public float GetHealth()
    {
        return health;
    }
}
