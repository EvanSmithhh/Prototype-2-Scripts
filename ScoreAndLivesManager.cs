using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAndLivesManager : MonoBehaviour
{
    // Declares global life and score variables
    static public int lives = 3;
    static public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Displays Score and Lives on the game's start
        Debug.Log("Lives: " + lives);
        Debug.Log("Score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        // Destroys the player and displays "Game Over!" if the player's life count hits 0
        if (lives < 1)
        { 
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}