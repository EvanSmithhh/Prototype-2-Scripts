using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public int hasRun = 0;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    // Destroys sandwich and animal on collision with each other OR decreases the player's life count if they are hit by an animal
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            ScoreAndLivesManager.score++;
            Debug.Log("Score: " +  ScoreAndLivesManager.score);
        }
        else if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreAndLivesManager.lives--;
            Debug.Log("Lives: " + ScoreAndLivesManager.lives);
        }
    }
}
