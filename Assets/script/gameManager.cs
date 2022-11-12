using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public int donutPoint;
    public bool isPause;

    void Awake()
    {
     donutPoint = 6;
     isPause = false;
    }

    void Update()
    {
     
    }

    public void Pause(){
        if(isPause == false){
            Time.timeScale = 0;
            isPause = true;
            return;
        }
        else{
            Time.timeScale = 1;
            isPause = false;
            return;
        }
    }

}
