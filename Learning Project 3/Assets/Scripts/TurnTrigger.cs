using UnityEngine;
using System.Collections;  // This is required for IEnumerator

public class TurnTrigger : MonoBehaviour
{
    private bool canTurn = true;  // Prevent multiple turns at once

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canTurn)
        {
            canTurn = false;
            StartCoroutine(WaitForTurnInput());
        }
    }

    IEnumerator WaitForTurnInput()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.A))  // Turn left
            {
                GameManager.Instance.Turn(-1);  // Rotate world left
                Destroy(gameObject);  // Remove turn block
                break;
            }
            else if (Input.GetKeyDown(KeyCode.D))  // Turn right
            {
                GameManager.Instance.Turn(1);  // Rotate world right
                Destroy(gameObject);  // Remove turn block
                break;
            }
            yield return null;
        }
    }
}
