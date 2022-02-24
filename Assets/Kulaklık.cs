using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Kulaklık : MonoBehaviour
{
    //[SerializeField] GameObject Kulaklik;
    [SerializeField] float AnimYmove;
    [SerializeField] float Animdu;

    // Start is called before the first frame update
    void Start()
    {
        //Kulaklik = gameObject.GetComponent<GameObject>();
        DOTween.Init();
        transform.DOLocalMoveY(AnimYmove, Animdu).SetLoops(-1, LoopType.Yoyo);

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController.numberofKulaklık += 1;
            Debug.Log("Kulaklık:" + PlayerController.numberofKulaklık);
            Destroy(gameObject);
        }
        
    }
   
}

