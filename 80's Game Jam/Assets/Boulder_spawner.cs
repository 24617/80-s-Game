using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder_spawner : MonoBehaviour
{
    [SerializeField] private GameObject BoulderPrefab;
    [SerializeField]  private float SpawnRate =30;
    private float TimeLeft =0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //elke 2 seconden kiezen of er een gespawned word, en dan elke keer kiezen of er dubbel gespawned word.
        TimeLeft -= Time.deltaTime;
        if (TimeLeft < 0)
        {
            TimeLeft = 60 / SpawnRate * Random.Range(0.75f,1.25f);
            SpawnBoulder();
        }
    }

    private void SpawnBoulder()
    {
        Instantiate(BoulderPrefab, transform);
    }
}
