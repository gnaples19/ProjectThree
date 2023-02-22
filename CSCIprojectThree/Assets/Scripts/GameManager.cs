using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public TextMeshProUGUI scoreText;
    private int score = 0;


    public void IncScore(int ds)
    {
        score += ds;
        scoreText.text = "Score : " + score;
    }

}