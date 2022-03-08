using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinSpawn : MonoBehaviour
{
   
    [SerializeField] float AnimYmove;
    [SerializeField] float Animdu;
    // Start is called before the first frame update
    void Start()
    {
       DOTween.Init();
        transform.DOLocalMoveY(AnimYmove, Animdu).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
