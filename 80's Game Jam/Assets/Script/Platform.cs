using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public GameObject Player;
    private float BodyLine = 0.25f;
    public float PlayerFeet;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        //Check player feet position & draw line based on feet
        PlayerFeet = Player.transform.position.y - BodyLine;
        Debug.DrawLine(Player.transform.position, new Vector3(Player.transform.position.x, Player.transform.position.y - BodyLine, Player.transform.position.z), Color.blue);

        //Check if platform is lower than players feet & if so: make player go through object
        for (int i = 0; i < transform.childCount; i++)
        {
            if (this.transform.GetChild(i).transform.position.y + 0.22f >= PlayerFeet)
            {
                Physics.IgnoreCollision(Player.GetComponent<Collider>(), this.transform.GetChild(i).GetComponent<Collider>());
            }
            else
            {
                Physics.IgnoreCollision(Player.GetComponent<Collider>(), this.transform.GetChild(i).GetComponent<Collider>(), false);
            }




        }
    }
}

