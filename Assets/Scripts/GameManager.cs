using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool IsLevelFinished;
    public PlayerController Player;

    public Text uiDistance;
    public Text uiKulakl�k;
    private int playerkulakl�k;
    public GameObject gameOverMenu;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        int distance = Mathf.RoundToInt(Player.transform.position.z-146f);
        uiDistance.text = distance.ToString() + "m";
        uiKulakl�k.text = playerkulakl�k.ToString();
    }

    public void Kulakl�kCollected()
    {
        playerkulakl�k++;
    }

    public void GameOver()
    {
        IsLevelFinished = true;
        Player.GetComponent<Animator>().enabled = false;
        Player.Joystick.gameObject.SetActive(false);
        gameOverMenu.SetActive(true);
    }
}
