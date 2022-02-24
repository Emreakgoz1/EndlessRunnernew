using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -10.6f;
    public static float rightSide = -0.89f;
    public float internalLeft;
    public float internalRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
