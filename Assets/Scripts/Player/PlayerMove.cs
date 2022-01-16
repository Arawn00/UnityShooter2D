using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer(new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical")));
    }
    void movePlayer(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
