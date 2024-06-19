using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI timeUI;
    [SerializeField] Canvas gameover;
    public int score  = 0;
    public float time = 60;
    // Start is called before the first frame update
    void Start()
    {

        gameover.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.SetText("SCORE: " + score);
        timeUI.SetText("TIME: " + time);
        time -= Time.deltaTime;

        if (time <= 0)
        {
            gameover.enabled = true;
            Time.timeScale = 0;
        }
    }

    public void buttonMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
