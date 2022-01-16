using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    int maxHealth = 3;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        Debug.Log(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // debug vie // 
        if(Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage(1);
           
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(currentHealth);

       if(currentHealth<=0)
        {
            Destroy(gameObject);
        }
    }
}
 
