using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnClickSound : MonoBehaviour
{
    // sound source component
    private AudioSource btnAudio;
    public AudioClip btnClickClip;  // 장애물과 충돌 시 도넛 잃는 소리

    void Awake()
    {
        // sound
        btnAudio = GetComponent<AudioSource>();  // 점프 소리가 기본
    }

    public void playSound(){
        // 버튼클릭소리
        btnAudio.clip = btnClickClip;
        btnAudio.Play();  // 사운드 재생
        Debug.Log("버튼 클릭");
    }
}
