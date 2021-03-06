using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool IsLevelFinished;
    public PlayerController Player;

    public Text uiDistance;
    public Text uiKulaklık;
    public GameObject gameOverMenu;
    public TextMeshProUGUI ScoreText;

    private int _playerkulaklık;
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
        uiKulaklık.text = _playerkulaklık.ToString();
    }

    public void KulaklıkCollected()
    {
        _playerkulaklık++;
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
