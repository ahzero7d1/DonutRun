using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_up_and_down : MonoBehaviour
{
    public float speed = 1f;
    bool switc = true;
    private SpriteRenderer spriteRenderer;
    Vector2 pos;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
            spriteRenderer.flipX = true;
        }
        else if (transform.position.x <= pos.x - 2)
        {
            switc = true;
            spriteRenderer.flipX = true;
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

}
