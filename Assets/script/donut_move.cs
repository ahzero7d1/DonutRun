using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donut_move : MonoBehaviour
{
    [SerializeField] Transform Player; //플레이어 
   // [SerializeField] Transform EndLine; //집 위치 
    //[SerializeField] Transform Donut;
    private float speed = 0.001f;
    private float firstPosition;
    private float firstYposition;
    private float maxPosition; 
    //비율만큼 위치 시키기 


    void Start()
    {
       // firstYposition = transform.position.y;
        //firstPosition = transform.position.x;
       // maxPosition = EndLine.position.x - Player.position.x;
       
    }

    void Update()
    {

        transform.Translate(new Vector3(3.2f * speed * Time.deltaTime, 0, 0));
        if (Player.position.y <= -5) // 낭떠러지로 떨어졌을때 위치 
        {
            speed = 0;
        }
        else
        {
            speed = 0.1f;
        }
        if (transform.position.x >1.8f) //상태바끝에 도달했을때 멈추기 
        {
            speed = 0;
        }

    }


}

