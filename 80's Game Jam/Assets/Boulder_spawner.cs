using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder_spawner : MonoBehaviour
{
    [SerializeField] private GameObject BoulderPrefab;
    [SerializeField]  private float spawnRate =30;
    private float timeLeft =0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //elke 2 seconden kiezen of er een gespawned word, en dan elke keer kiezen of er dubbel gespawned word.
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 60 / spawnRate * Random.Range(0.75f,1.25f);
            SpawnBoulder();
            Debug.Log("sfgsdgglslgkgjk");
        }
    }

    private void SpawnBoulder()
    {
        Instantiate(BoulderPrefab, transform);
    }
}
