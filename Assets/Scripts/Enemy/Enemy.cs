using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1;
    public GameObject deathEffect;
    private float currentLifeTime = 0;
    public float maxLifeTime;

     void Update()
    {
        currentLifeTime += 1;
        if (currentLifeTime >= maxLifeTime)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage (int damage)
   {
        health -= damage;

        if(health<=0)
        {
            Die();
        }

void Die()
    {
     // Instantiate(deathEffect, transform.position, Quaternion.identity);
     Destroy(gameObject);
    }
  }
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Bullet"))
        {
            TakeDamage(1);
        }
    }
}
