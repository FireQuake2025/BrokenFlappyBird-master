using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    public TMP_Text ScoreText;
    public GameObject TitleScreen;
    public GameObject ReadyScreen;
    public GameObject GameoverScreen;
    public GameObject ScoreUI;

    public void UpdateScore(int score)
    {
        ScoreText.text = $"Score: {score}";
    }

    public void ShowStart()
    {
        TitleScreen.SetActive(true);
        ReadyScreen.SetActive(false);
        GameoverScreen.SetActive(false);
        ScoreUI.SetActive(false);
    }

    public void HideStart()
    {
        TitleScreen.SetActive(false);
    }

    public void ShowReady()
    {
        TitleScreen.SetActive(false);
        ReadyScreen.SetActive(true);
        GameoverScreen.SetActive(false);
    }

    public void HideReady()
    {
        ReadyScreen.SetActive(false);
        ScoreUI.SetActive(true);
    }

    public void ShowGameOver()
    {
        GameoverScreen.SetActive(true);
    }


}
