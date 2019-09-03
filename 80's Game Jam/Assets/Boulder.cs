using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    public float Speed = 1;
    public bool SpeedActive = false;
    public GameObject Threshold;
    // Start is called before the first frame update
    void Start()
    {
        Threshold = GameObject.Find("threshold");
    }

    // Update is called once per frame
    void Update()
    {
        if(SpeedActive == true)
        {
            transform.position += new Vector3(Speed, 0, 0);
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
            SpeedActive = true;
        }

        if (other.gameObject.tag == "Wall")
        {
            speed = -speed;
        }
    }
}
