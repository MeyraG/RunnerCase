using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerControl playerControl;
    public Text levelText;
    public bool isPlaying;
    public Text totalCookieText;


    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level_end")
        {
            CalculateCookie();
        }
    }
    public void StartTheGame()
    {
        isPlaying = true;
    }

    public void EndGame()
    {
        isPlaying = false;
        SceneManager.LoadScene("Level_End");
    }

    public void Replay()

    {
        if (SceneManager.GetActiveScene().name == "Level_end")
        {
            isPlaying = true;
            SceneManager.LoadScene("Level_01");
        }
    }

    public void Quit()
    {
        Debug.Log("Her bitiş yeni şeylerin başlangıcıdır. Cheers!");
        Application.Quit();
    }

    public void CalculateCookie()
    {
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            sum += PlayerPrefs.GetInt($"Level{i}", 0);
        }
        totalCookieText.text = "TOTAL COOKIE :" + sum;
    }
}