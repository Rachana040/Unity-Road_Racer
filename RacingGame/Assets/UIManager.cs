using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    // Use this for initialization
    public Text scoreText;
    int score;
    bool gameOver;
    public Button[] buttons;
	void Start () {
        score = 0;
        gameOver = false;
        InvokeRepeating("scoreUpdate",1.0f,0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score.ToString();
	}

    public void finish()
    {
        gameOver = true;
        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
    public void Pause()
    {
        if (Time.timeScale == 0)
            Time.timeScale = 1;
        else if (Time.timeScale == 1)
            Time.timeScale = 0;
    }

    public void replay()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void menu()
    {
        Application.LoadLevel("MainMenu");
    }
   public void exit()
    {
        Application.Quit();
    }
    void scoreUpdate()
    {
        if(!gameOver)
           score = score + 1;

    }
    public void Play()
    {
        Application.LoadLevel ("level1");
    }
}
