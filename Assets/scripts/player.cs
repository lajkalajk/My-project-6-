using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player : MonoBehaviour
{       
    public float speed;
    public float turnSpeed;
    private float turn;
    public new Rigidbody2D rigidbody;
    public bullet bulletPrefab;
    public explosion explosionPrefab;
    public Text healthText;
    public Text timeText;
    int health = 3;
    int score;
    string zero = "Game over, press x to reset health and score";
    string one = "❤";
    string two = "❤❤";
    string three = "❤❤❤";
    float time;

    private void Start()
    {
        healthText.text = three;
    }
    void Update()
    {

        if (health == 3)
        {
            healthText.text = three;
        }
        if (health > 0)
        {
            time = time + Time.deltaTime;
            timeText.text = "Time survived: " + time;
            if (Input.GetKey(KeyCode.A))
            {
                turn = 1f;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                turn = -1f;

            }
            else
            {
                turn = 0f;
            }

            if (Input.GetKey(KeyCode.W))
            {
                rigidbody.AddForce(transform.up * speed);
            }
            if (turn != 0f)
            {
                rigidbody.AddTorque(turn * turnSpeed);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                bullet bullet = Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
                
                bullet.Shoot(this.transform.up);
                rigidbody.AddForce(transform.up * -speed);
            }

            if (health == 2)
            {
                healthText.text = two;
            }
            if (health == 1)
            {
                healthText.text = one;
            }
        }
        else
        {
            explosion explosion = Instantiate(explosionPrefab, this.transform.position, this.transform.rotation);
            explosion.SelfDestruct(5);
            
            healthText.text = zero;

            if (Input.GetKey(KeyCode.X))
            {
                health = 3;
                time = 0f;
            }

        }
    }

        public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
            explosion explosion = Instantiate(explosionPrefab, this.transform.position, this.transform.rotation);
            explosion.SelfDestruct(0.5f);
            health -= 1;
        }
    }
}
