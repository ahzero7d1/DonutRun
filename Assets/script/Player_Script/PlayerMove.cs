using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid;

    public int playerSpeed;
    public gameManager GameManager;
    public float jumpPower;
    public bool doublejump;



    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        doublejump = false;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(playerSpeed,rigid.velocity.y);
        
        
    }

    void Update(){

        //이단점프까지만 되도록 하기
        if(Input.GetButtonDown("Jump")){//doublejump가 false인 경우 1단점프
            Debug.DrawRay(rigid.position, Vector3.down, new Color(0,1,0));
            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position,Vector3.down,1,LayerMask.GetMask("platform"));
            Debug.Log(rayHit.distance);

            if(rayHit.distance < 0.7f&& rayHit.distance >0.4f){
                rigid.AddForce(Vector2.up*jumpPower,ForceMode2D.Impulse);
                doublejump = true;}

            else if((rayHit.distance == 0f || rayHit.distance > 0.7f) && doublejump ){//doublejump가 true인 경우 2단 점프
                rigid.AddForce(Vector2.up*jumpPower,ForceMode2D.Impulse);
                doublejump = false;
            }
        }  

        }
          
    }