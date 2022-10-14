using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;   //플립을 하기 위해서
    [SerializeField] float speed = 1.0f;   // 스피드

    private Vector2 direction;


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x > 0)
        {
            sprite.flipX = false; // 걸어갈때 시선처리
        }
        else if (x < 0)
        {
            sprite.flipX = true;
        }

        transform.Translate(x * speed * Time.deltaTime, y * speed * Time.deltaTime, transform.position.z); //이동 속도
    }

    //유니티 2D 에서는 2D Collidoer랑 Rigidbody 2D는 2D 충돌 함수를 사용해야 합니다.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("2D 충돌 Collision");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("2D 충돌 중 Collision");

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("2D 충돌 벗어남 Collision");

    }





    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("2D 충돌");

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("2D 충돌 중");

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("2D 충돌 중");

    }
}
