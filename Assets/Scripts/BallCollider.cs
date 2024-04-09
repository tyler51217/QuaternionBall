using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallCollider : MonoBehaviour
{

    public static int scoreInt;
    public TMP_Text scoreText;
    void Start()
    {
        
        BallCollider.scoreInt = 0;
        scoreText.text = "0";
    }

    void OnCollisionEnter2D(Collision2D collision) 
    { 
        if (collision.gameObject.CompareTag("Paddle")) 
        {
            Debug.Log("collider works");
            scoreInt++;
            scoreText.text = scoreInt.ToString();
            return;
        }

        if (collision.gameObject.CompareTag("DeathPlane"))
        {
            Debug.Log("game over");
        }
    }
    


}
