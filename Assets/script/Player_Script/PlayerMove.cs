using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer sprite;
    Animator anim;

    public gameManager GameManager;
    public int playerSpeed;
    public float jumpPower = 700.0f;

    private int jumpCount =0;
    private bool isGrounded;

    



    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        jumpPower = 500f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(playerSpeed,rigid.velocity.y);
        Debug.DrawRay(rigid.position, Vector3.down, new Color(0,1,0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position,Vector3.down,1,LayerMask.GetMask("Platform"));
    }

    void Update(){
        //점프하기
        if(Input.GetButtonDown("Jump")&&jumpCount<2){//doublejump가 false인 경우 1단점프
            jumpCount++;

            rigid.velocity = Vector2.zero;
            //rigid.AddForce(new Vector2(0,jumpPower));
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

            //Debug.Log("미는힘:" + jumpPower+new Vector2(0,jumpPower));

        }
        else if(Input.GetButtonUp("Jump")&&rigid.velocity.y>0)
            rigid.velocity = rigid.velocity*0.5f;
        anim.SetBool("Grounded", isGrounded);

        Slide();
        OnDamaged();
        }

    void Slide(){
        if(Input.GetKey(KeyCode.DownArrow))
          Debug.Log("슬라이드를 했습니다."); //이거는 sprite 이미지 받고 collider 변경해서 넣기
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag =="Obstacle"){
            //GameManager.donutPoint -=1;
            GameManager.DonutDown();

            //플레이어 튕겨서 1초동안 멈춰서 놀라기
            //OnDamaged();
            Debug.Log("부딪힘");
        }
        
        else if(collision.gameObject.tag =="floor"){
            if(collision.contacts[0].normal.y>0.7f){
                isGrounded = true;
                jumpCount=0;
                
            }

        }
    }

    void OnCollisionExit2D(Collision2D collision){
        isGrounded =false;

    }
    
    void OnDamaged(){
        //투명하게 하기
        //놀라는 표정 애니메이션 추가 필요!!
        GameManager.isPause = true;
     //   GameManager.Pause();
        //Invoke("Pause",50);
    }

    public void OnDie() {
        //1. 뒤에 시간 멈추기
        GameManager.isPause = true;
        GameManager.End();
    }
}

   

