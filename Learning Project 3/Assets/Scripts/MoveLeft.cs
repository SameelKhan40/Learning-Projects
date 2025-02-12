using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerControllerScript playerControllerScript;
    private float leftBound = -20;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerScript>();
    }

    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            // Get movement direction from GameManager, but ignore the Y axis
            Vector3 movementDirection = GameManager.Instance.GetMovementDirection();
            movementDirection.y = 0;  // Ensure the Y-axis is unaffected

            // Move the object in the calculated direction
            transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
        }

        // Destroy the obstacle when it moves past the left bound
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
