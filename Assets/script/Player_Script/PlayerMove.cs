using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer sprite;
    Animator anim;

    public int playerSpeed;
    public gameManager GameManager;
    public float jumpPower;
    public bool doublejump;
    public float defaultRay;
    



    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(playerSpeed,rigid.velocity.y);
        Debug.DrawRay(rigid.position, Vector3.down, new Color(0,1,0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position,Vector3.down,1,LayerMask.GetMask("Platform"));
    }

    void Update(){
        Jump();
        Slide();
        OnDamaged();

        
        }

        void Jump(){
            //이단점프까지만 되도록 하기
            if(Input.GetButtonDown("Jump")){//doublejump가 false인 경우 1단점프
                rigid.AddForce(Vector2.up*jumpPower,ForceMode2D.Impulse);
               
                Debug.DrawRay(rigid.position, Vector3.down, new Color(0,1,0));
                RaycastHit2D rayHit = Physics2D.Raycast(rigid.position,Vector3.down,1,LayerMask.GetMask("platform"));
                Debug.Log(rayHit.distance);
                

                //if( doublejump == false ){//jumpPower 고려해서 바꾸기
                    //rigid.AddForce(Vector2.up*jumpPower,ForceMode2D.Impulse);
                    //doublejump = true;}

                //else if((rayHit.distance == 0f || rayHit.distance > 0.7f ) && doublejump ){//doublejump가 true인 경우 2단 점프
                    //rigid.AddForce(Vector2.up*jumpPower,ForceMode2D.Impulse);
                    //doublejump = false;
            }
            //땅이랑 안 닿아있으면 Setbool = true, 아니면 false
        }  
    

    void Slide(){
        if(Input.GetKey(KeyCode.DownArrow))
          Debug.Log("슬라이드를 했습니다."); //이거는 sprite 이미지 받고 collider 변경해서 넣기
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag =="Obstacle"){
            GameManager.donutPoint -=1;
            //플레이어 튕겨서 1초동안 멈춰서 놀라기
            OnDamaged();
        }

    }
    
    void OnDamaged(){
        rigid.AddForce(new Vector2(-1,1),ForceMode2D.Impulse);
        //놀라는 표정 애니메이션 추가 필요!!
        GameManager.isPause = true;
        Invoke("Pause",1);
    }
}

   

