using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    RaycastHit hit;



    private float left = -1;
    private float right = 1;
    public float chosenNumber;
    public float extra;
    public int reach = 1;
    

    void Start()
    {
        chosenNumber = Random.Range(0, 2) == 0 ? left : right; ;
    }


    void Update()
    {

        transform.Translate(Vector3.left * chosenNumber * Time.deltaTime);

        if (chosenNumber == left)
        {
            if (Physics.Raycast(new Vector3(transform.position.x - (0.27f * (chosenNumber * chosenNumber)), transform.position.y, transform.position.z),
                                new Vector3(transform.position.x - (0.27f * (chosenNumber * chosenNumber)), transform.position.y - 0.5f, transform.position.z),
                                out hit, Mathf.Infinity))
            {
                if (hit.transform.tag != "floor" && hit.transform.tag == null )
                {
                    chosenNumber = right;
                    Debug.Log(hit.transform.tag);
                    
                }

            }


            Debug.DrawLine(new Vector3(transform.position.x - (0.27f * (chosenNumber * chosenNumber)), transform.position.y, transform.position.z), new Vector3(transform.position.x - (0.27f * (chosenNumber * chosenNumber)), transform.position.y - 0.25f, transform.position.z), Color.red);
        }

        if (chosenNumber == right)
        {
            if (Physics.Raycast(new Vector3(transform.position.x + (0.27f * (chosenNumber * chosenNumber)), transform.position.y, transform.position.z),
                                new Vector3(transform.position.x + (0.27f * (chosenNumber * chosenNumber)), transform.position.y - 0.5f, transform.position.z),
                                out hit, Mathf.Infinity))
            {
                if (hit.transform.tag != "floor" && hit.transform.tag == null)
                {
                    chosenNumber = left;
                }

            }


            Debug.DrawLine(new Vector3(transform.position.x + (0.27f * (chosenNumber * chosenNumber)), transform.position.y, transform.position.z), new Vector3(transform.position.x + (0.27f * (chosenNumber * chosenNumber)), transform.position.y - 0.25f, transform.position.z), Color.red);
        }
    }

  
}
