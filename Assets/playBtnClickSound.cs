using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playBtnClickSound : MonoBehaviour
{
    // sound source component
    private AudioSource playerAudio;
    // sound clip
    public AudioClip btnClickClip;  // 장애물과 충돌 시 도넛 잃는 소리

    void Awake() {
        // sound
        playerAudio = GetComponent<AudioSource>();  // 점프 소리가 기본
    } 

    void playSound() {
        playerAudio.Play();  // 재생
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
