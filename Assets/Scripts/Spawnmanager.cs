using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    PiotSpawner plotSpawner;
    //test
    // Start is called before the first frame update
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        plotSpawner = GetComponent<PiotSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        plotSpawner.SpawnKose();
    }
}