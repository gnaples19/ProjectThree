using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    // Start is called before the first frame update
    public int gameStartScreen; 

    public void StartGame(){
        SceneManager.LoadScene(gameStartScreen);
    }
}
