using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_fryingpan : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody2D rigid;
    Vector2 playerPos;
    Vector3 target;
    Vector3 player_target;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();

        playerPos = GameObject.Find("Player").transform.position;
        player_target = new Vector3(playerPos.x, playerPos.y, 0);
        target = new Vector3(playerPos.x-5, playerPos.y, 0);
    }

    void FixedUpdate()
    {
        MoveToPlayer1();
    }

    void ONCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            Invoke("Deactive", 3);
        }
    }

    void Deactive()
    {
        gameObject.SetActive(false);
    }

    void MoveToPlayer1()
    {
        rigid.AddForce(Vector2.right*0.2f, ForceMode2D.Impulse);

    }
}
