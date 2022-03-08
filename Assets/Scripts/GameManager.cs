using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private GameObject Player;
    public Text uiDistance;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        int distance = Mathf.RoundToInt(Player.transform.position.z);
        uiDistance.text = distance.ToString() + "m";
    }
}
