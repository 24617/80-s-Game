using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public GameObject player;
    public float bodyLine = 0.25f;
    public float playerFeet = 0;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        //Check player feet position & draw line based on feet
        playerFeet = player.transform.position.y - bodyLine;
        Debug.DrawLine(player.transform.position, new Vector3(player.transform.position.x, player.transform.position.y - bodyLine, player.transform.position.z), Color.blue);

        //Check if platform is lower than players feet & if so: make player go through object
        for (int i = 0; i < transform.childCount; i++)
        {
            if (this.transform.GetChild(i).transform.position.y + 0.22f >= playerFeet)
            {
                Physics.IgnoreCollision(player.GetComponent<Collider>(), this.transform.GetChild(i).GetComponent<Collider>());
            }
            else
            {
                Physics.IgnoreCollision(player.GetComponent<Collider>(), this.transform.GetChild(i).GetComponent<Collider>(), false);
            }
        }
    }
}

