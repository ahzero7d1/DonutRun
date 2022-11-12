using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameManager : MonoBehaviour
{
    public int donutPoint;
    public bool isPause;
    public PlayerMove player;

    // 도넛 이미지 배열
    public Image[] UIDonut;

    // 엔딩 
    public GameOverScreen GameOverImage;
    public GameOverScreen Retrybutton;



    void Awake()
    {
     donutPoint = 6;
     isPause = false;
    }

    void Update()
    {
     
    }

    
    public void End(){
        if(isPause == true){
            Time.timeScale = 0;           
        }
        // 2. 죽었다는 UI image 넣기
        // -> Deactive / active 해서 / Canvas에 고정
        GameOverImage.Setup();
        Retrybutton.Setup();
    }
    

    public void DonutDown(){
        if(donutPoint > 1) {
            donutPoint--;
            UIDonut[donutPoint].color = new Color(1, 1, 1, 0.2f);
        }
        else if(donutPoint == 1) {
            donutPoint--;
            UIDonut[donutPoint].color = new Color(1, 1, 1, 0.2f);
            Debug.Log("죽었습니다.");
            player.OnDie();
        }
    }

    public void Restart(){
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");

    }
}
