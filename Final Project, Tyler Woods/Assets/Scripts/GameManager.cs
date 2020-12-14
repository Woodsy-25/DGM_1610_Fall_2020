using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    private bool isIt = true;
    public TextMeshProUGUI it, win, notIt, lose, timerText, gameOverText;
    public Button restart;
    public GameObject titleScreen;
    private AudioSource gameAudio;
    public AudioClip click, loseAudio, winAudio;
    private float timer = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        gameAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = "Time Left: " + timer;
        if ( timer < 0.0 )
        {
            GameOver();
        }
     
    }

    //for then the game ends
    public void GameOver()
    {
        //turns of the timer and who is it
        timerText.gameObject.SetActive(false);
        restart.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        //shows if the player won or lost
        if(isIt)
        {
            lose.gameObject.SetActive(true);
            gameAudio.PlayOneShot(loseAudio);
        }
        if(!isIt)
        {
            win.gameObject.SetActive(true);
            gameAudio.PlayOneShot(winAudio, 0.2f);
        }
    }

    //resets the game to the title screen
    public void RestartGame()
    {
        gameAudio.PlayOneShot(click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //starts the game (timer, who is it)
    public void StartGame()
    {
        gameAudio.PlayOneShot(click);
        isGameActive = true;
        timer = 60;
        timerText.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
    }
    
    //takes care of showing who is it
    public void It()
    {
        isIt = true;
        it.gameObject.SetActive(true);
        notIt.gameObject.SetActive(false);
    }
    //also takes care oof who is it
    public void NotIt()
    {
        isIt = false;
        notIt.gameObject.SetActive(true);
        it.gameObject.SetActive(false);
    }
}
