using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class EngelSpawner : MonoBehaviour
{
    private int spawnÝnterval = 65;
    private int lastSpawnZ = 190;
    private int spawnAmount = 1;
    private int kulaklýkspawnAmount= 5;
    public List<GameObject> Obstacles;
    

    public GameObject kulaklýk;

    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnObstacles()
    {
        lastSpawnZ += spawnÝnterval;
        for (int i = 0; i < spawnAmount; i++)
        {
                GameObject obstacle = Obstacles[Random.Range(0, Obstacles.Count)];
                Instantiate(obstacle, new Vector3(0, 0, lastSpawnZ), obstacle.transform.rotation);
            if (Random.Range(0, 2) == 1)
            {
                ObstacleCollectableSpace space = obstacle.GetComponent<ObstacleCollectableSpace>();
                Instantiate(kulaklýk, new Vector3(space.GetLane(), 1, lastSpawnZ + 1.5f), kulaklýk.transform.rotation);
            }
            else
            {
                if (Random.Range(0,2)==1)
                {

                }
                Instantiate(kulaklýk, new Vector3(0, 1, lastSpawnZ + 1.5f), kulaklýk.transform.rotation);
            }
            
        }
    }
}
