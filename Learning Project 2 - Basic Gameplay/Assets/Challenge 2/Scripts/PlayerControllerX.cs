using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float nextSpawnTime = 0f; // Time until next dog can be spawned
    private float cooldownTime = 2.0f; // Cooldown interval in seconds

    // Update is called once per frame
    void Update()
    {
        // Check if the spacebar is pressed and the cooldown has passed
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextSpawnTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextSpawnTime = Time.time + cooldownTime; // Set the next allowed spawn time
        }
    }
}