using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;   //�ø��� �ϱ� ���ؼ�
    [SerializeField] float speed = 1.0f;   // ���ǵ�

    private Vector2 direction;


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x > 0)
        {
            sprite.flipX = false; // �ɾ�� �ü�ó��
        }
        else if (x < 0)
        {
            sprite.flipX = true;
        }

        transform.Translate(x * speed * Time.deltaTime, y * speed * Time.deltaTime, transform.position.z); //�̵� �ӵ�
    }

    //����Ƽ 2D ������ 2D Collidoer�� Rigidbody 2D�� 2D �浹 �Լ��� ����ؾ� �մϴ�.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("2D �浹 Collision");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("2D �浹 �� Collision");

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("2D �浹 ��� Collision");

    }





    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("2D �浹");

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("2D �浹 ��");

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("2D �浹 ��");

    }
}
