using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donut_move : MonoBehaviour
{
    public Distance dis;
    public Vector3 donutPlacement;
    float StartDonut;

    void Awake(){
        StartDonut = transform.position.x;

    }

    public void FixedUpdate(){
        donutPlacement = new Vector3(StartDonut+ (dis.totalDistance - dis.distance)*0.01f,transform.position.y,transform.position.z);
        transform.position = donutPlacement;
    }

    void Update()
    {
        /*transform.Translate(new Vector3(3.2f * speed * Time.deltaTime, 0, 0));
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
        }*/

    }


}

