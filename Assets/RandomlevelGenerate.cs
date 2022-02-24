using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlevelGenerate : MonoBehaviour
{
    public GameObject[] section;
    public int  zPos = 55;
    public bool createSession = false;
    public int Bolnum;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (createSession==false)
        {
            createSession = true;
            StartCoroutine(GenerateSection());
            
        }    
    }
    IEnumerator GenerateSection()
    {
        Bolnum = Random.Range(0, 3);
        Instantiate(section[Bolnum], new Vector3(0, 0, zPos+125), Quaternion.identity);
        zPos += 55;
        yield return new WaitForSeconds(3);
        createSession = false;
    }
    
}
