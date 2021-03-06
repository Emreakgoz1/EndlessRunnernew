using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    BinaSpawn plotSpawner;
    EngelSpawner engelspawner;
    
    // Start is called before the first frame update
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        plotSpawner = GetComponent<BinaSpawn>();
        engelspawner = GetComponent<EngelSpawner>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        plotSpawner.SpawnKose();
        engelspawner.SpawnObstacles();
        
        
    }
}
