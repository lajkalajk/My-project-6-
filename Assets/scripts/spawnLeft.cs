using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class spawnLeft : MonoBehaviour
{
    public small_asteroid smallPrefab;
    public big_asteroid bigPrefab;

    void Update()
    {
        float rnd = Random.Range(0, 200);
        if (rnd == 100)
        {
            float rndRotation = Random.Range(-30, -150);
            float rndPosition = Random.Range(-4, 4);
            transform.position = new Vector3(-10, rndPosition, 0);
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
