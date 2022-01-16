using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 20;
    private float currentLifeTime =0;
    public float maxLifeTime;
    

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
     void Update()
    {
        currentLifeTime += 1;
        if(currentLifeTime>=maxLifeTime)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D hitInfo)

    {
       Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy!=null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
    
  
}
