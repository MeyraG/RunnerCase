using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    ScoreControl scoreControl;
    public int level = 1;
    public Text levelText;

    public GameManager gameManager;

    private void Start()
    {
        scoreControl = gameObject.GetComponent<ScoreControl>();
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Collectible")
        {
            Destroy(col.gameObject);

            scoreControl.GetCookie();
        }

        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);

            scoreControl.LostCookie();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            int levelIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt($"Level{levelIndex}", scoreControl.cookie);

            SceneManager.LoadScene(levelIndex + 1);
        }

        if (other.gameObject.tag == "LastFinish")
        {
            int levelIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt($"Level{levelIndex}", scoreControl.cookie);
            gameManager.EndGame();
        }
    }
}