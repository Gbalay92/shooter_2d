using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneScript : MonoBehaviour
{
    public void Init(){
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit_Button_Click(){
        Application.Quit();
    }
}
