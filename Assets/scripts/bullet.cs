using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;

    public float duration;

    public explosion explosionPrefab;

    public void Shoot(Vector2 direction)
    {
        rb.AddForce(direction * speed);
        Destroy(this.gameObject, duration);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject); 
        explosion explosion = Instantiate(explosionPrefab, this.transform.position, this.transform.rotation);
        explosion.SelfDestruct(0.5f);
    }

}
