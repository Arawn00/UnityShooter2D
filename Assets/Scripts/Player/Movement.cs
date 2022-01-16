using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    public float AccelerationFactor;
    public float DecelerationFactor;
    private Vector3 velocity;


    // Update is called once per frame
    void Update()
    {
        float xs = Input.GetAxis("Horizontal");
        float ys = Input.GetAxis("Vertical");
        Debug.Log("XS:" + xs);

        //compute acceleration vector
        Vector3 acceleration = new Vector3(ys, 0, 0);
        acceleration.Normalize();

        // Move the object forward along its z axis 1 unit/second.
        //transform.Translate(xs, 0, Time.deltaTime);
        
       

        //compute speed
        velocity += acceleration * AccelerationFactor * Time.deltaTime;

        //change position
        Vector3 speedVector = velocity * Speed * Time.deltaTime;
        transform.Translate(speedVector.x, 0, 0, Space.Self);
        

        //Deceleration
        velocity *= DecelerationFactor;

        
    }
    // direction 
    
}
