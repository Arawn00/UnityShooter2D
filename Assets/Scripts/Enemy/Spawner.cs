using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ennemy;
    public int xPos;
    public int yPos;
    public int ennemyCount;

    void Start()
    {
        StartCoroutine(EnnemyDrop());
    }

    IEnumerator EnnemyDrop()
    {
        while (ennemyCount < 10)
        {
            xPos = Random.Range(8, -8);
            yPos = Random.Range(8, -8);
            Instantiate(ennemy, new Vector3(xPos, yPos, 1), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            ennemyCount += 1;
        }
    }
}
