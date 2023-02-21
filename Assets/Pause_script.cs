using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_script : MonoBehaviour
{
    public static bool isGamePaused = false;
    [SerializeField]public GameObject pause_menu;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(isGamePaused){
                Resume();
            }else{
                Pause();
            }
        }
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

    public void LoadMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
