using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {

    public Button[] buttons;
	public Button pause;
    public Text scoreText;
	public Text gameOverText;
	public Text currentScore;
    bool gameOver;
    int score;
    

    




    // Use this for initialization
    void Start () {
    
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
		currentScore.text = "Your Score : " + score;
        //score++;
	}

    void scoreUpdate()
    {
        if (!gameOver)
        {
            score++;
        }
    }

    public void gameOverActivated()
    {
        gameOver = true;

        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
		gameOverText.gameObject.SetActive(true);
		currentScore.gameObject.SetActive (true);

		scoreText.gameObject.SetActive (false);
		pause.gameObject.SetActive (false);

    }

    public void Pause()
    {
        if(Time.timeScale == 1)
        {
            
            Time.timeScale = 0;
        }
        else if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void Play()
    {
        Application.LoadLevel("Level 1");
        Time.timeScale = 1;
    }

    public void Menu()
    {
        Application.LoadLevel("menu");
    }

    public void Exit()
    {
        Application.Quit();
    }


}
