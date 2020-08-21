using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class gameUI : MonoBehaviour
{
    // field
    public GameObject gameTitle; 
    public GameObject gameOverTitle; 
    public GameObject playButton; 
    public bool IsPlaying = false;
    public GameObject startCanvas;
    public playerSkill playerskill;
    public GameObject player;
    public healthBar playerhealthbar;
    public changeScene changescene = new changeScene();

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
        Destroy(startCanvas);
    }

    public bool getIsPlaying()
    {
        return IsPlaying;
    }

    public void RestartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        //healthbar.setMaxHealth(5);// set health bar to max hp 
        //print(changeScene.playerMaxHealth);

        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "SampleScene")
        {
            changescene.setPlayerHealth(5);
            print("reload 1");
        }
        else if (sceneName == "scene2")
        {
            playerhealthbar.setMaxHealth(5);
            playerhealthbar.setHealth(changeScene.changeScenePlayerHealth);
            changescene.setPlayerHealth(changeScene.changeScenePlayerHealth);
            print("reload 2");
        }


    }
}
