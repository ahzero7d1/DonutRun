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
    public Text happy_text;

    // 도넛 이미지 배열
    public Image[] UIDonut;

    // 엔딩 
    public GameOverScreen GameOverImage;
    public GameOverScreen Retrybutton;
    public Success_Screen success_Screen;
    public Success_Screen Successbutton;
    public Success_Text happy_text_script;

    //크림존
    public ScrollingObject House;
    public ScrollingObject House1;
    public ScrollingObject Mt;
    public ScrollingObject Mt2;
    public repeatt TileMap;
    public repeatt CreamZone1;
    public repeatt CreamZone2;
    public repeatt CreamZone3;
    public repeatt CreamZone4;
    public repeatt CreamZone5;
    public repeatt CreamZone6;
    public repeatt CreamZone7;
    public repeatt Bird;
    public repeatt Bird1;
    public repeatt Bird2;
    public repeatt Bird3;
    public repeatt Bird4;
    public repeatt Bird5;
    public repeatt Bird6;
    public repeatt Bird7;
    public repeatt Bird8;
    public repeatt Bird9;
    public repeatt Bird10;
    public repeatt Bird11;
    public repeatt Bird12;
    public repeatt Bird13;
    public repeatt Bird14;
    public repeatt Bird15;
    public repeatt Bird16;
    public repeatt Bird17;
    public repeatt Bird18;

    // 버튼 클릭 사운드
    // sound source component
    private AudioSource btnAudio;
    // sound clip
    public AudioClip btnClickClip;  // 장애물과 충돌 시 도넛 잃는 소리

    void Awake()
    {
        donutPoint = 6;
        isPause = false;

        // sound
        btnAudio = GetComponent<AudioSource>();
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

    public void Success(){
        if(isPause == true)
            Time.timeScale=0;

        success_Screen.Setup();
        Successbutton.Setup();
        happy_text.text = "도넛 "+(donutPoint).ToString()+"개 획득!!";
        happy_text_script.Setup();
        //happy_text.SetActive(true);
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

    public void SlowDown(){
        House.speed =3;
        House1.speed = 3;
        Mt.speed = 1;
        Mt2.speed = 1;
        TileMap.speed = 2.5f;
        CreamZone1.speed = 2.5f;
        CreamZone2.speed = 2.5f;
        CreamZone3.speed = 2.5f;
        CreamZone4.speed = 2.5f;
        CreamZone5.speed = 2.5f;
        CreamZone6.speed = 2.5f;
        CreamZone7.speed = 2.5f;
        Bird.speed = 2.5f;
        Bird1.speed = 2.5f;
        Bird2.speed = 2.5f;
        Bird3.speed = 2.5f;
        Bird4.speed = 2.5f;
        Bird5.speed = 2.5f;
        Bird6.speed = 2.5f;
        Bird7.speed = 2.5f;
        Bird8.speed = 2.5f;
        Bird9.speed = 2.5f;
        Bird10.speed = 2.5f;
        Bird11.speed = 2.5f;
        Bird12.speed = 2.5f;
        Bird13.speed = 2.5f;
        Bird14.speed = 2.5f;
        Bird15.speed = 2.5f;
        Bird16.speed = 2.5f;
        Bird17.speed = 2.5f;
        Bird18.speed = 2.5f;
    }

   public void SpeedUp(){
        House.speed =6;
        House1.speed = 6;
        Mt.speed = 2;
        Mt2.speed = 2;
        TileMap.speed = 5f;
        CreamZone1.speed = 5f;
        CreamZone2.speed = 5f;
        CreamZone3.speed = 5f;
        CreamZone4.speed = 5f;
        CreamZone5.speed = 5f;
        CreamZone6.speed = 5f;
        CreamZone7.speed = 5f;
        Bird.speed = 5f;
        Bird1.speed = 5f;
        Bird2.speed = 5f;
        Bird3.speed = 5f;
        Bird4.speed = 5f;
        Bird5.speed = 5f;
        Bird6.speed = 5f;
        Bird7.speed = 5f;
        Bird8.speed = 5f;
        Bird9.speed = 5f;
        Bird10.speed = 5f;
        Bird11.speed = 5f;
        Bird12.speed = 5f;
        Bird13.speed = 5f;
        Bird14.speed = 5f;
        Bird15.speed = 5f;
        Bird16.speed = 5f;
        Bird17.speed = 5f;
        Bird18.speed = 5f;
    }

    public void Restart(){
        Time.timeScale = 1;

        // 버튼 클릭 사운드
        btnAudio.clip = btnClickClip;
        btnAudio.Play();

        SceneManager.LoadScene("Main");
    }
}
