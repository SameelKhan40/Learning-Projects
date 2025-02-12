using UnityEngine;

public class BackgroundReset : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    void Start()
    {
        startPos = transform.localPosition;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    {
        // Get the current "forward" direction of the parent (worldTransform)
        Vector3 movementDirection = -transform.right;  // Move opposite to the parent's forward direction
        transform.Translate(movementDirection * Time.deltaTime * 30);

        // Adjust the reset condition based on the new direction (use the magnitude)
        if (Vector3.Distance(transform.localPosition, startPos) > repeatWidth)
        {
            transform.localPosition = startPos;
        }
    }
}
