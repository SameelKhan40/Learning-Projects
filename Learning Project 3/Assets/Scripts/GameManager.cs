using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;  // Singleton instance for easy access
    public Transform worldTransform;     // Assign the parent of all moving obstacles/backgrounds
    private Vector3 movementDirection = Vector3.left;  // Initial movement direction

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void Turn(int direction)  // direction: 1 for right, -1 for left
    {
        float turnAngle = 90f * direction;  // Rotate by 90 degrees
        movementDirection = Quaternion.Euler(0, turnAngle, 0).eulerAngles ;

        // Rotate the world smoothly
//        worldTransform.rotation = Quaternion.Euler(0, worldTransform.rotation.eulerAngles.y + turnAngle, 0);
        worldTransform.DORotate(new Vector3(0, worldTransform.rotation.eulerAngles.y + turnAngle, 0),2f);
        Debug.Log(worldTransform.rotation.eulerAngles.y);
        Debug.Log(movementDirection.y);
    }

    public Vector3 GetMovementDirection()
    {
        return movementDirection;
    }
   
}
