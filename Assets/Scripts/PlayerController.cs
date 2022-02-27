using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] public  float movementSpeed = 10f;
    public Spawnmanager spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal") * movementSpeed;
        float Vertical = Input.GetAxis("Vertical") * movementSpeed / 2;

        transform.Translate(new Vector3(Horizontal, 0, Vertical) * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
