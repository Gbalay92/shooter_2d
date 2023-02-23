using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject john;
    // Update is called once per frame
    void Update()
    {   
        if(Pause_script.isGamePaused){
            GetComponent<AudioSource>().Pause();
        }else if(!Pause_script.isGamePaused && !GetComponent<AudioSource>().isPlaying){ 
            GetComponent<AudioSource>().Play();
        }
        if(john==null){return;}
        Vector3 position = transform.position;
        position.x = john.transform.position.x;
        transform.position = position;
    }
}
