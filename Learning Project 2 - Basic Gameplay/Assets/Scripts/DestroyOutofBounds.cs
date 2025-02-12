using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{

    private float topbound = 30;
    private float lowerbound = -10;
    private float rightbound = 21;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbound )
        {
            Destroy(gameObject);
            
        }
        else if (transform.position.z < lowerbound)
        {
            Destroy(gameObject);
            
            Debug.Log("Game Over !!");
            Application.Quit();
        }
        else if(transform.position.x > rightbound){
            Destroy(gameObject);
            Debug.Log("Game Over !!");
            Application.Quit();
        }
    }
}
