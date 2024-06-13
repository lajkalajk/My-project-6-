using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class big_asteroid : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float duration = 5;
    public small_asteroid smallPrefab;


    public void Shoot(Vector2 direction)
    {
        rb.AddForce(direction * Random.Range(speed - 10, speed + 10));
        Destroy(this.gameObject, this.duration);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        float rnd = Random.Range(-5, 5);
        float z = this.transform.position.z + rnd;
        
        small_asteroid small1 = Instantiate(smallPrefab, this.transform.position, Quaternion.Euler(0,0,z));
        small1.Shoot(this.transform.up); 
        small_asteroid small2 = Instantiate(smallPrefab, this.transform.position, Quaternion.Euler(0, 0, z));
        small2.Shoot(this.transform.up);
    }
}
