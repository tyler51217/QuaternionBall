using UnityEngine;
using UnityEngine.UI;

public class BallCollider : MonoBehaviour
{
    
    
    public Rigidbody2D ball;
    public Button restartButton;
    public Button mainMenuButton;
    public GameObject paddle;
    private const float INITIAL_FORCE = -100;
    
    
    private void Start()
    {
        ball.AddForce(transform.up * INITIAL_FORCE);
    }

    void OnCollisionEnter2D(Collision2D collision) 
    { 
        if (collision.gameObject.CompareTag("Paddle")) 
        {
            ScoreUI.AddScore();
            return;
        }

        if (collision.gameObject.CompareTag("DeathPlane"))
        {
            restartButton.gameObject.SetActive(true);
            mainMenuButton.gameObject.SetActive(true);
            paddle.gameObject.SetActive(false);
        }
    }

    
    
}
