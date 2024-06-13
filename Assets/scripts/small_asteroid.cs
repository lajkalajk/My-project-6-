using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class small_asteroid : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float duration = 5;


    public void Shoot(Vector2 direction)
    {
        rb.AddForce(direction * Random.Range(speed - 10, speed + 10));
        Destroy(this.gameObject, this.duration);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
