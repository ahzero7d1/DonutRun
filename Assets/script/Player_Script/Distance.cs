using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public Transform sucessZone;
    public float distance;
    public float totalDistance;

    public void Awake(){
        totalDistance = (sucessZone.transform.position.x - transform.position.x);
    }

    public void Update(){
        distance = (sucessZone.transform.position.x - transform.position.x);
        Debug.Log(totalDistance +"이랑" +distance);

        if(distance <= 0){
            Debug.Log("Finish");
            //도넛 멈추게 하기 함수 불러오기
        }
    }

}
