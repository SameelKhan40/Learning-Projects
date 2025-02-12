using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject turnBlockPrefab;  // Reference to the turn block prefab
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerControllerScript playerControllerScript;
    private int spawnCounter = 0;  // Counter to track when to spawn turn block

    void Start()
    {
        InvokeRepeating("SpawnObstacleOrTurnBlock", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerScript>();
    }

    void SpawnObstacleOrTurnBlock()
    {
        if (!playerControllerScript.gameOver)
        {
            spawnCounter++;
            if (spawnCounter % 5 == 0)  // Spawn a turn block every 5th obstacle
            {
                Instantiate(turnBlockPrefab, spawnPos, turnBlockPrefab.transform.rotation);
            }
            else
            {
                Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            }
        }
    }
}
