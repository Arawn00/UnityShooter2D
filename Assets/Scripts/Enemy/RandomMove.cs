using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public float speed;
    public Vector3 direction = Vector3.up; //(0,0,0)
    bool running = false;
    Vector3 destination;
    Rigidbody2D rb;


    // destroy after X sec 
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
    if(!running)
        {
            StartCoroutine(changeDirection()); // change direction 
        }

        //destination = transform.position + direction;//direction * distance in order to get the destination 
        //transform.position += direction * speed;
        //transform.position = Vector3.Lerp(transform.position, destination, Time.deltaTime*2);
        //rb.AddForce(direction * speed,ForceMode2D.Force); // option 1 
        rb.velocity += new Vector2(direction.x, direction.y)*Time.deltaTime; // option 2 
    }
    IEnumerator changeDirection()
    {
        running = true;
        yield return new WaitForSeconds(4);
        direction.x = UnityEngine.Random.Range(-1, 1);
        direction.y = UnityEngine.Random.Range(-1, 1);
         running = false;
    }
    
}
