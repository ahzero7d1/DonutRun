using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid;

    public int playerSpeed;
    public gameManager GameManager;
    public float jumpPower;
    private int jumps;



    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(playerSpeed,rigid.velocity.y);
        Debug.DrawRay(rigid.position, Vector3.down, new Color(0,1,0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position,Vector3.down,1,LayerMask.GetMask("Platform"));
    }

    void Update(){
        jumps = 0;
        //일단점프
        if (jumps == 0  && Input.GetButtonDown("Jump")){
            jumps = jumps +1;
            Jump();
            //if 땅이랑 닿으면 점프를 다시 할 수 있도록 - raycast

        }

    }

//이단점프까지만 되도록 하기
    public void Jump(){
        rigid.AddForce(Vector2.up*jumpPower,ForceMode2D.Impulse);
    }
}
