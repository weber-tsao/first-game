using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameUI : MonoBehaviour
{

    public GameObject gameTitle; 
    public GameObject gameOverTitle; 
    public GameObject playButton; 
    public bool IsPlaying = false; 

    // Start is called before the first frame update
    void Start()
    {
        gameTitle.SetActive(true); 
        gameOverTitle.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        IsPlaying = true; 
        gameTitle.SetActive(false); 
        playButton.SetActive(false); 
    }

    public bool getIsPlaying()
    {
        return IsPlaying;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }
}
