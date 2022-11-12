using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_left_and_right : MonoBehaviour
{
    public float speed = 1f;
    Rigidbody2D rigid;
    bool switc = true;
    private SpriteRenderer spriteRenderer;
    Vector2 pos;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        pos = transform.position;
    }

    void Update()
    {
        if (switc)
        {
            movebirdright();
        }
        else
        {
            movebirdleft();
        }

        if (transform.position.x >= pos.x + 2)
        {
            switc = false;
            spriteRenderer.flipX = false;
        }
        if (transform.position.x <= pos.x - 4)
        {
            switc = true;
            spriteRenderer.flipX = true;
        }
    }

     void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag =="Player"){
            rigid.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
        }
        
    }

    void movebirdright()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    void movebirdleft()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

    public void crash(){
        rigid.AddForce(Vector2.up * 100f, ForceMode2D.Impulse);
    }

}
