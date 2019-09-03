using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float movementSpeed = 3f;
    public bool grounded;
    public bool onLadder;
    public bool ladderTouch;
    public float playerLadderFeet;
    public Platform platform;
    public Transform ladder;


        


    private void Start()
    {
        platform = GameObject.Find("Floors").GetComponent<Platform>();
    }

    void Update()
    {
        playerLadderFeet = platform.player.transform.position.y - 0.25f;

        if (onLadder == false || playerLadderFeet >= (ladder.transform.position.y + (ladder.localScale.y / 2)) || playerLadderFeet <= (ladder.transform.position.y - (ladder.localScale.y / 2)))
        {
                if (Input.GetKey("a"))
                {
                    transform.Translate(Vector3.left * 3 * Time.deltaTime);
                    onLadder = false;
                }

                if (Input.GetKey("d"))
                {
                    transform.Translate(Vector3.right * 3 * Time.deltaTime);
                    onLadder = false;
                }
        }

        if (Input.GetKey("w") && ladderTouch == true)
        {  
            if (playerLadderFeet >= (ladder.transform.position.y + (ladder.localScale.y / 2)))
            {
                transform.position = new Vector3(transform.position.x, ladder.transform.position.y + (ladder.localScale.y / 2) + 0.25f, transform.position.z);
                Debug.Log("work");
            } else
            {
                onLadder = true;
                GetComponent<Rigidbody>().useGravity = false;
                transform.Translate(Vector3.up * 3 * Time.deltaTime);
                transform.position = new Vector3(ladder.position.x, transform.position.y, transform.position.z);
                Debug.Log("dont");
            }
        }

        if (Input.GetKey("s") && ladderTouch == true)
        {
            if (playerLadderFeet <= (ladder.transform.position.y - (ladder.localScale.y / 2)))
            {
                transform.position = new Vector3(transform.position.x, ladder.transform.position.y - (ladder.localScale.y / 2) + 0.25f, transform.position.z);
            } else
            {
                onLadder = true;
                GetComponent<Rigidbody>().useGravity = false;
                transform.Translate(Vector3.down * 3 * Time.deltaTime);
                transform.position = new Vector3(ladder.position.x, transform.position.y, transform.position.z);
            }
        }

        if (Input.GetKeyDown("space") && grounded == true)
        {

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor" && onLadder == false)
        {
            grounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            grounded = false;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ladder")
        {
            ladderTouch = true;
            ladder = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ladder")
        {
            ladderTouch = false;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }

}
