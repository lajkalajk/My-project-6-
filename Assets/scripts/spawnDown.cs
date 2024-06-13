using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnDown : MonoBehaviour
{
    public big_asteroid bigPrefab;
    public small_asteroid smallPrefab;
    void Update()
    {
        float rnd = Random.Range(0, 200);
        if (rnd == 100)
        {
            float rndRotation = Random.Range(-60, 60);
            float rndPosition = Random.Range(-7, 7);
            transform.position = new Vector3(rndPosition, -5.5f, 0);
            transform.rotation = Quaternion.Euler(0, 0, rndRotation);
            float rndSize = Random.Range(0, 8);
            if (rndSize == 4)
            {
                big_asteroid big = Instantiate(bigPrefab, this.transform.position, this.transform.rotation);
                big.Shoot(this.transform.up);
            }
            else
            {
                small_asteroid small = Instantiate(smallPrefab, this.transform.position, this.transform.rotation);
                small.Shoot(this.transform.up);
            }

        }
    }
}
