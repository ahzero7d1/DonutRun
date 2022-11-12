using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public int donutPoint;
    public bool isPause;
    public PlayerMove player;
    public Image[] UIDonut;

    void Awake()
    {
     donutPoint = 6;
     isPause = false;
    }

    void Update()
    {
     
    }

    public void DonutDown(){
        if(donutPoint>1){
            donutPoint--;
            UIDonut[donutPoint].color = new Color(1, 1, 1, 0.2f);
        }
        else{
            //Player Die Effect
            //player.OnDie();  //OnDie() PlayerMove에서 구현해야 됨

            //UI 구현 필요
            //Result UI
            
            //Retry Button UI
        }
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
