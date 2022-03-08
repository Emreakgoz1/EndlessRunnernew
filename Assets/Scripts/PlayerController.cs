using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    public Spawnmanager spawnManager;
    public FloatingJoystick Joystick;
    public float movementSpeed = 10f;
    public float LeftRightSpeed = 5;

    [SerializeField] float jumppower;
    [SerializeField] Transform model;

    Animator PlayerAnim;
    float Horizontal;
    float Vertical;
    bool isjumping;

    void Start()
    {
        DOTween.Init();
        PlayerAnim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (GameManager.Instance.IsLevelFinished)
            return;

        //float Horizontal = Input.GetAxis("Horizontal") * LeftRightSpeed;
        Horizontal = Joystick.Horizontal * LeftRightSpeed;
        //float Vertical = Input.GetAxis("Vertical") * movementSpeed / 2; 
        transform.Translate(new Vector3(Horizontal, 0, Vertical) * Time.deltaTime);
        transform.position += new Vector3(Horizontal * LeftRightSpeed, 0, movementSpeed) * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerAnim.SetTrigger("jump");
            PlayerAnim.SetBool("isGround", true);

            if (!isjumping)
            {
                isjumping = true;
                model.DOLocalJump(model.localPosition, jumppower, 1, 1).OnComplete(() =>
                {
                    isjumping = false;
                });
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SpawnTrigger")
        {
            spawnManager.SpawnTriggerEntered();
        }
    }   
}
