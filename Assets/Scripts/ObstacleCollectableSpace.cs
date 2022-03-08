using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollectableSpace : MonoBehaviour
{
    public List<float> collectablelaneX;
    public List<float> collectableJumpsX;

    public float GetLane()
    {
        if (collectablelaneX == null || collectablelaneX.Count < 1)
        {
            return -30f;
        }
        return collectablelaneX [Random.Range(0, collectablelaneX.Count)];
    }

    public float GetJump()
    {
        if (collectableJumpsX == null || collectableJumpsX.Count < 1 )
        {
            return -30f;
        }
        return collectableJumpsX[Random.Range(0, collectableJumpsX.Count)];
    }
}
