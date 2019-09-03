using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    public float speed = 1;
    public bool speedActive = false;
    public GameObject Threshold;
    // Start is called before the first frame update
    void Start()
    {
        Threshold = GameObject.Find("threshold");
    }

    // Update is called once per frame
    void Update()
    {
        if(speedActive == true)
        {
            transform.position += new Vector3(speed, 0, 0);
            //speedActive = false;
        }



        if (gameObject.transform.position.y <= Threshold.transform.position.y)
        {
            Destroy(this.gameObject);
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Floor")
        {
            speedActive = true;
        }

        if (other.gameObject.tag == "Wall")
        {
            speed = -speed;
        }
    }
}
