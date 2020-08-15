using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class gameUI : MonoBehaviour
{

    public GameObject gameTitle; 
    public GameObject gameOverTitle; 
    public GameObject playButton; 
    public bool IsPlaying = false;
    public GameObject startCanvas;
    public playerSkill playerskill;
    public GameObject player;
    //public int time;

    // Start is called before the first frame update
    void Start()
    {
        gameTitle.SetActive(true);
        //time = playerskill.getSlashTime();
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
        Destroy(startCanvas);
    }

    public bool getIsPlaying()
    {
        return IsPlaying;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }

    public void starBurstSteam()
    {
        Invoke("playerskill.fireSkillwww", 0f);
    }
}
