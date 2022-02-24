using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] public GameObject Player;
   [SerializeField] Rigidbody PlayerRigidbody;
    [SerializeField] float MoveSpeed;
    float Horizontal;
    float Vertical;
    [SerializeField] float leftRightSpeed;
    [SerializeField] float jumppower;
    //[SerializeField] float verticalspeed;
    //[SerializeField] float jumpspeed;
    [SerializeField] Transform model;
    bool isjumping;
    Animator PlayerAnim;
    public static int numberofKulaklýk;
    
    
   
    void Start()
    {
        PlayerRigidbody = gameObject.GetComponent<Rigidbody>();
        numberofKulaklýk = 0;
        DOTween.Init();
        PlayerAnim = gameObject.GetComponent<Animator>();
       
        //PlayerRigidbody.isKinematic = false;
    }
    void Update()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        { 
                    PlayerAnim.SetTrigger("jump");
                    PlayerAnim.SetBool("isGround", true);
   
        if (!isjumping)
            {
                    isjumping = true;
                    model.DOLocalJump(model.localPosition, jumppower, 1, 1).OnComplete(()=> {
                    isjumping = false;
             
                 });
            }

        }
                   transform.position += new Vector3(Horizontal * leftRightSpeed, 0, MoveSpeed) * Time.deltaTime;
       
       
        if (this.gameObject.transform.position.x>LevelBoundary.leftSide)
        {
                   transform.position += (Vector3.left * Time.deltaTime * leftRightSpeed);
            
        }
        if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
        {
                   transform.position += (Vector3.left * Time.deltaTime * leftRightSpeed*-1);
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Engel"))
        {
            Debug.Log("engele takýldýn");
        }
    }
}
