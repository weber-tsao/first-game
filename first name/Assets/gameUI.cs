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
        playerskill.fireSkill(12);
        playerskill.fireSkill(13);
        playerskill.fireSkill(9);
        playerskill.fireSkill(15);
        playerskill.fireSkill(4);
        playerskill.fireSkill(10);
        playerskill.fireSkill(8);
        playerskill.fireSkill(1);
        playerskill.fireSkill(6);
        playerskill.fireSkill(2);
        playerskill.fireSkill(5);
        playerskill.fireSkill(11);
        playerskill.fireSkill(0);
        playerskill.fireSkill(14);
        playerskill.fireSkill(3);
        playerskill.fireSkill(7);
    }
}
