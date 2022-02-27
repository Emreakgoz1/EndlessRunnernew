using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiotSpawner : MonoBehaviour
{
    private int initamount = 5;
    private float pLotSize = 60f;
    private float xPosleft = -20.7f;
    private float xPosRight = 20.7f;
    private float lastZpos = 15f;

    public List<GameObject> Koseler;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initamount; i++)
        {
            SpawnKose();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnKose()
    {
        GameObject KoselerLeft = Koseler[Random.Range(0, Koseler.Count)];
        GameObject KoselerRight = Koseler[Random.Range(0, Koseler.Count)];
        float zPos = lastZpos + pLotSize;
        Instantiate(KoselerLeft, new Vector3(xPosleft, 0.025f, zPos), KoselerLeft.transform.rotation);
        Instantiate(KoselerRight, new Vector3(xPosRight, 0.025f, zPos), new Quaternion(0, 180, 0, 0));
        lastZpos += pLotSize;
    }
}
