using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootProj();
        }
    }
    void ShootProj()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
