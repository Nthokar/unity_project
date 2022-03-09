using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clicker : MonoBehaviour
{
    public Text ScoreText;
    public int Score;

    public void AddScore()
    {
        Score++;
        ScoreText.text = $"{Score}";
    }
}