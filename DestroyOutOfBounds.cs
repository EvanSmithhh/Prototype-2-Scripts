using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBound = 30;
    public float lowerBound = -10;
    public float xBoundRange = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroys gameObjects at the top of the screen (Food) and decreases the player's life count
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
            ScoreAndLivesManager.lives--;
            Debug.Log("Lives: " + ScoreAndLivesManager.lives);
        }

        // Destroys gameObjects at the bottom of the screen (Animals)
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }

        // Destroys gameObjects that leave the left side of the screen (Animals)
        else if (transform.position.x < -xBoundRange)
        {
            Destroy(gameObject);
        }

        // Destroys gameObjects that leave the right side of the screen (Animals)
        else if (transform.position.x > xBoundRange)
        {
            Destroy(gameObject);
        }

    }
}
