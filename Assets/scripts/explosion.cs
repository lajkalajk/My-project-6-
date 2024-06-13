using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public void SelfDestruct(float duration)
    {
        Destroy(this.gameObject, duration); 
    }
}
