using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 20f;
    public float turnspeed = 10f;
    public float horizontalinput;
    public float verticalinput;

    // Update is called once per frame
    void Update()
    {
        verticalinput = Input.GetAxis("Vertical");
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalinput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalinput);
        
    }
}
