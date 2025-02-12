using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerLeftRight : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //spawning leftright.
    private float spawnPosX = 20;
    private float spawndelay = 4;
    private float spawninterval = 3f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimalLeftRight", spawndelay, spawninterval);
    }
    void Update()
    {

    }

    void SpawnRandomAnimalLeftRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(0,25));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

}
