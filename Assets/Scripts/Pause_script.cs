using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_script : MonoBehaviour
{
    public static bool isGamePaused = false;
    [SerializeField]public GameObject pause_menu;
    public JohnMovement john;
    [SerializeField]public GameObject game_over;

    void Update()
    {
    
        if(john == null && !isGamePaused){
            GameOver();
        }
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(isGamePaused){
                Resume();
            }else{
                Pause();
            }
        }
    }
    public void GameOver(){
        game_over.SetActive(true);
        Time.timeScale=0f;
        isGamePaused=true;
    }
    public void Resume(){
        pause_menu.SetActive(false);
        Time.timeScale=1f;
        isGamePaused=false;
    }

    public void Pause(){
        pause_menu.SetActive(true);
        Time.timeScale=0f;
        isGamePaused=true;
    }

    public void ToMainScene(){
        Resume();
        SceneManager.LoadScene("MainScene");
    }

    public void Restart(){
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit_Button_Click(){
        Application.Quit();
    }
}
