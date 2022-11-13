using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ChangeScene : MonoBehaviour
{

    // sound source component
    private AudioSource playerAudio;
    // sound clip
    public AudioClip btnClickClip;  // 장애물과 충돌 시 도넛 잃는 소리
    
    void Awake() {
        // sound
        playerAudio = GetComponent<AudioSource>();  // 점프 소리가 기본
    } 

    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "StoryButton":
                //button click sound
                playerAudio.Play();  // 재생
                Debug.Log("클릭됨");    

                SceneManager.LoadScene("StoryScene");
                break;
        }


    }

    public void changeSceneAnim(){
        //대화 애니메이션이 다 뜨면 StoryScene -> Main
        // SceneManager.LoadScene("Main");
    }



}
