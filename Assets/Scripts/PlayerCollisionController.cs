using System.Collections;
using UnityEngine;

public class PlayerCollisionController : MonoBehaviour
{
    public Spawnmanager spawnManager;
    public PlayerController playercontroller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Kulaklik")
        {
            GameManager.Instance.KulaklýkCollected();    
            Destroy(other.gameObject);
        }
        if (other.tag =="Engel")
        {
            GameManager.Instance.GameOver();
        }
    }

    private IEnumerator WaitAndRestart(float WaitTime)
    {
        yield return new WaitForSeconds(WaitTime);
        GameManager.Instance.GameOver();
    }
}
