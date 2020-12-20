using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float projectileRotationAmount = 360f;
    [SerializeField] private float damage = 50;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed, Space.World);
        transform.Rotate(0,0, Time.deltaTime * projectileRotationAmount);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider2D)
    {
        var health = otherCollider2D.GetComponent<Health>();
        var attacker = otherCollider2D.GetComponent<Attacker>();

        if (attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
