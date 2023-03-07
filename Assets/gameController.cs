using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{

    public int Score;
    public Text scoreText;


    void Start()
    {
        Time.timeScale = 1;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(0);
    }

}
