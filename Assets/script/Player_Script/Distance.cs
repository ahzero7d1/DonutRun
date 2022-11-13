using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public Transform sucessZone;
    public float distance;

    public void Update(){
        distance = (sucessZone.transform.position.x - transform.position.x);
        Debug.Log(distance);

        if(distance <= 0){
            Debug.Log("Finish");
        }
    }

}
