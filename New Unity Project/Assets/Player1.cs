using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;   //플립을 하기 위해서
    [SerializeField] float speed = 1.0f;   // 스피드

    Rigidbody2D rigid2D;

    private void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();

    }

    //private Vector2 direction;


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");

        if (x > 0)
        {
            sprite.flipX = false; // 걸어갈때 시선처리
        }
        else if (x < 0)
        {
            sprite.flipX = true;
        }

        transform.Translate(x * speed * Time.deltaTime, transform.position.y * speed * Time.deltaTime, transform.position.z); //이동 속도
    }

    private void FixedUpdate()
    {
        //Rigidbody에 대한 연산같은 경우 Fixed에서 처리해야한다.

        if (Input.GetKeyDown(KeyCode.Space))//키코드를 통해가지고 한다. 버튼다운은 정해져있는거
        {

        }


    }






    //유니티 2D 에서는 2D Collidoer랑 Rigidbody 2D는 2D 충돌 함수를 사용해야 합니다.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Portal"))
        {
            Camera.main.transform.position = new Vector3(10, 0,Camera.main.transform.position.z);   //카메라 위치가 x 축으로 10 만큼 감
            transform.position = new Vector3(12.5f, 0, 0); //캐릭터도 12.5 만큼 위치 이동 잡아줌
        }
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
