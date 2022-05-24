using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreControl : MonoBehaviour
{
    public int cookie;

    [SerializeField]
    Text cookieText;

    public void GetCookie()
    {
        cookie++;
        cookieText.text = "COOKIE X " + cookie;
    }

    public void LostCookie()
    {
        cookie--;
        cookieText.text = "COOKIE X " + cookie;
    }
}