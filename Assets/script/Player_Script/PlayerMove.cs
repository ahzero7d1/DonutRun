using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer sprite;
    Animator anim;
    // sound source component
    private AudioSource playerAudio;

    public gameManager GameManager;
    public Obstacle_left_and_right bird;
    public int playerSpeed;
    public float jumpPower;
    // sound clip
    public AudioClip losingDonutClip;  // 장애물과 충돌 시 도넛 잃는 소리
    public AudioClip jumpClip;  // 점프 소리 (1단)
    public AudioClip jumpClip2;  // 점프 소리 (2단)



    private int jumpCount =0;
    private bool isGrounded;
    Vector3 target;
    Vector3 targetRespawn;

    
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        target = new Vector3(-3f,-2f,0f);
        targetRespawn = new Vector3(-3f,1.5f,0f);
        
        // sound
        playerAudio = GetComponent<AudioSource>();  // 점프 소리가 기본

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

            // sound
            if(jumpCount == 1)  playerAudio.clip = jumpClip;  // 점프 소리로 변경
            else if(jumpCount == 2)  playerAudio.clip = jumpClip2;  // 점프 소리로 변경

            playerAudio.Play();  // 재생    

        }
        else if(Input.GetButtonUp("Jump")&&rigid.velocity.y>0)
            rigid.velocity = rigid.velocity*0.5f;
            anim.SetBool("Grounded", isGrounded);

        Captured();
        Respawn();
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag =="Obstacle"){
            //GameManager.donutPoint -=1;
            OnDamaged();
        }
        
        else if(collision.gameObject.tag =="floor"){
            if(collision.contacts[0].normal.y>0.7f){
                isGrounded = true;
                jumpCount=0;
                
            }
        } 

        else if(collision.gameObject.tag == "Finish"){
            GameManager.isPause = true;
            GameManager.Success();
        }
    }

    void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.tag =="floor")
        isGrounded =false;
    }

   /* void OnTriggerEnter2D(Collider2D collision){
        
    }*/
    
    void OnDamaged(){
        // sound (도넛 차감되는 소리)
        playerAudio.clip = losingDonutClip;
        playerAudio.Play();  // 사운드 재생

        //투명하게 하기
        //놀라는 표정 애니메이션 추가 필요!!
        GameManager.DonutDown();
        Debug.Log("부딪힘");
        gameObject.layer = 9;
        //놀라는 표정
        anim.SetTrigger("Damaged");
        sprite.color = new Color(1,0.6f,0.6f,0.8f);
        Invoke("OffDamaged",3);
    }

    void OffDamaged(){
        sprite.color = new Color(1,1,1,1);
        rigid.gravityScale = 3f;
        gameObject.layer = 8;
    }

    public void OnDie() {
        //1. 뒤에 시간 멈추기
        GameManager.isPause = true;
        GameManager.End();
    }

    public void Captured(){
        if(transform.position.x < -7){
            transform.position = Vector3.MoveTowards(transform.position,target, 1f);
            // 시간되면 엔딩신 하나 더 만들기
        }
    }

    public void Respawn(){
        if(transform.position.y < -10){
            OnDamaged();
            transform.position = Vector3.MoveTowards(transform.position,targetRespawn, 10f);
            

    }}

    
}

   

