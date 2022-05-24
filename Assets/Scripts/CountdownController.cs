using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public Text countdownText;

    GameManager gameManager;
    void Start()
    {
        StartCoroutine(CountdowntoStart());
    }

    IEnumerator CountdowntoStart()
    {
        while (countdownTime > 0)
        {
            countdownText.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownText.text = "START!";

        yield return new WaitForSeconds(1f);

        FindObjectOfType<GameManager>().StartTheGame();

        countdownText.gameObject.SetActive(false);
    }
}