using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10.0f;
    private float spawnRangeTopZ = 15.0f;
    private float spawnRangeBottomZ = 1.0f;
    private float spawnPosZ = 20.0f;
    private float spawnPosX = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Auto spawns animals
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Spawns random animals at random positions along the top of the screen
    void SpawnRandomAnimal() {
            Vector3 spawnPosHor = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Vector3 spawnPosVerL = new Vector3(-spawnPosX, 0, Random.Range(-spawnRangeBottomZ, spawnRangeTopZ));
            Vector3 spawnPosVerR = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeBottomZ, spawnRangeTopZ));
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            int spawnSide = Random.Range(0, 3);
            if (spawnSide == 0)
            {
                Instantiate(animalPrefabs[animalIndex], spawnPosHor, animalPrefabs[animalIndex].transform.rotation);
            }
            else if (spawnSide == 1) 
            {
                Instantiate(animalPrefabs[animalIndex], spawnPosVerL, Quaternion.Euler(0, 90, 0));
            }
            else if (spawnSide == 2)
            {
                Instantiate(animalPrefabs[animalIndex], spawnPosVerR, Quaternion.Euler(0, 270, 0));
            }
    }       
    
}
