using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject Home,GamePlay,GameOver;
    public TMPro.TextMeshProUGUI scoreTxt;
    public static UIManager instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Home.SetActive(true);
    }
   public void StartGame()
    {
        Home.SetActive(false);
        GamePlay.SetActive(true);
        GameManager.instance.startGame();
    }

    public void GameFinish()
    {

    }

    public void SendScore(int value)
    {
        scoreTxt.text ="AGE: "+ value.ToString();
    }

    public void RestartGame()
    {
        GameManager.instance.RestartGame();
    }

    public void ShowGameOver()
    {
        GameOver.SetActive(true);
    }
}
