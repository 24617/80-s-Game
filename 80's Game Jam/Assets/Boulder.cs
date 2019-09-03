using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    public float speed = 1;
    public GameObject Threshold;
    // Start is called before the first frame update
    void Start()
    {
        Threshold = GameObject.Find("threshold");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0);
        //if(transform.position <=  )
        if (gameObject.transform.position.y <= Threshold.transform.position.y)
        {
            Destroy(this.gameObject);
            Debug.Log("test");
        }
    }
}
