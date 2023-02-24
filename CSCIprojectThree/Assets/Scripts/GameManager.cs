using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}

    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }

    }

    public void RestartLevel(int level){
        SceneManager.LoadScene(level);
    }


    public void StartGame() {
        score = 0;
        scoreText.text = "Score : " + score; 
    }
    
    public void Loadthisscene(int i){
        SceneManager.LoadScene(i);
    }

    public void IncScore(int ds)
    {
        score += ds;
        scoreText.text = "Score : " + score;
    }

 
}