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
    public TextMeshProUGUI it;
    public TextMeshProUGUI win;
    public TextMeshProUGUI notIt;
    public TextMeshProUGUI lose;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI gameOverText;
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

    public void GameOver()
    {
        timerText.gameObject.SetActive(false);
        restart.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
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

    public void RestartGame()
    {
        gameAudio.PlayOneShot(click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        gameAudio.PlayOneShot(click);
        isGameActive = true;
        timer = 60;
        timerText.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
    }
    
    public void It()
    {
        isIt = true;
        it.gameObject.SetActive(true);
        notIt.gameObject.SetActive(false);
    }

    public void NotIt()
    {
        isIt = false;
        notIt.gameObject.SetActive(true);
        it.gameObject.SetActive(false);
    }
}
