using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private float movementSpeed = 3f;
    private bool grouned;
 
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * 3 * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * 3 * Time.deltaTime);
        }

        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.up * 3 * Time.deltaTime);
        }

        if (Input.GetKeyDown("space"))
        {

        }
    }
}
