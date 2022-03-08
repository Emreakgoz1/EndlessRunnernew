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

        Horizontal = Joystick.Horizontal * LeftRightSpeed;
        Vector3 position = transform.position;
        position += new Vector3(Horizontal * LeftRightSpeed, 0, movementSpeed) * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(position.x, -10, 10), position.y, position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isjumping)
            {
                PlayerAnim.SetTrigger("jump");
                PlayerAnim.SetBool("isGround", true);

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
