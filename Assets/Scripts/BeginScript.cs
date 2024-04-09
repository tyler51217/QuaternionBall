using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginScript : MonoBehaviour
{
    public Rigidbody2D ball;
    // Start is called before the first frame update
    void Start()
    {
        ball.AddForce(transform.up * -100);
        
    }

    
}
