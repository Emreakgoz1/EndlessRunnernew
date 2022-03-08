using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool IsLevelFinished;
    public PlayerController Player;

    public Text uiDistance;
    public Text uiKulakl�k;
    public GameObject gameOverMenu;
    public TextMeshProUGUI ScoreText;

    private int _playerkulakl�k;
    private int _score;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        int distance = Mathf.RoundToInt(Player.transform.position.z - 146f);
        _score = distance;
        uiDistance.text = distance.ToString() + "m";
        uiKulakl�k.text = _playerkulakl�k.ToString();
    }

    public void Kulakl�kCollected()
    {
        _playerkulakl�k++;
    }

    public void GameOver()
    {
        ScoreText.SetText(_score.ToString());
        IsLevelFinished = true;
        Player.GetComponent<Animator>().enabled = false;
        Player.Joystick.gameObject.SetActive(false);
        gameOverMenu.SetActive(true);
    }
}
