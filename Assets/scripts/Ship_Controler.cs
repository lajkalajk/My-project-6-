using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Controler : MonoBehaviour
{
    public float Spead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Angledistance;     
        float frameTime = Time.deltaTime;
        Quaternion ship = new Quaternion(0, 0, transform.rotation.z,0);
        if ( Input.GetKey(KeyCode.A) )
        {
            Angledistance = Spead * frameTime;
            ship.x += Angledistance;
            Debug.Log("pressed A");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Angledistance = Spead * frameTime; 
            ship.x -= Angledistance;
            Debug.Log("pressed D");
        }
        transform.rotation = ship;
    }
}
