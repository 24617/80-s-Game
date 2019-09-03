using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skell : MonoBehaviour
{
    [SerializeField] private float Speed = 1;
    private float moveWidth;
    Vector3 platformLoc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move left until platform ends. them move right, hence and repeat
        transform.position += new Vector3(Speed, 0, 0);
        if(transform.position.x <= platformLoc.x * moveWidth)
        {
            Speed = -Speed;
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        moveWidth = other.gameObject.transform.localScale.x;
        platformLoc = other.gameObject.transform.position;
        Debug.Log(moveWidth);
    }
}
