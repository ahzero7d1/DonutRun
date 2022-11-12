using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour

{
    public PlayerMove player;
    private Vector3 offset;

    void Start()
    {
        //offset = transform.position - player.transform.position;
    }

    void Update()
    {
        //this.transform.position.x = new Vec3(0, 0, 0);
        //player.transform.position.x;
        //Vector3 pos = player.transform.position + offset;
        //transform.position = new Vector3(pos.x+5f, transform.position.y, transform.position.z);
    }
}
