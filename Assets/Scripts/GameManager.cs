using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool IsLevelFinished;
    public PlayerController Player;

    public Text uiDistance;
    public Text uiKulaklık;
    private int playerkulaklık;
    public GameObject gameOverMenu;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        int distance = Mathf.RoundToInt(Player.transform.position.z-146f);
        uiDistance.text = distance.ToString() + "m";
        uiKulaklık.text = playerkulaklık.ToString();
    }

    public void KulaklıkCollected()
    {
        playerkulaklık++;
    }

    public void GameOver()
    {
        IsLevelFinished = true;
        Player.GetComponent<Animator>().enabled = false;
        Player.Joystick.gameObject.SetActive(false);
        gameOverMenu.SetActive(true);
    }
}
