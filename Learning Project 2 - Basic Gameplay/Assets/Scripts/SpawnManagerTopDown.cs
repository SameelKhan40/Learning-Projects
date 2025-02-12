using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerTopDown : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //spawning topdown.
    private float spawnPosZ = 30;
    private float spawnRangeX = 20;
    private float spawndelay = 4;
    private float spawninterval = 3f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTopDown",spawndelay, spawninterval);
    }

    void SpawnRandomAnimalTopDown()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

}
