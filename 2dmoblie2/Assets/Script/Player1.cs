using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;   //�ø��� �ϱ� ���ؼ�
    [SerializeField] float speed = 1.0f;   // ���ǵ�
    [SerializeField] float jumpPower = 1.0f; // ���� �Ŀ�

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
            sprite.flipX = false; // �ɾ�� �ü�ó��
        }
        else if (x < 0)
        {
            sprite.flipX = true;
        }

        transform.Translate(x * speed * Time.deltaTime, 0, transform.position.z); //�̵� �ӵ�

        //Rigidbody�� ���� ���갰�� ��� Fixed���� ó���ؾ��Ѵ�.

       

    }

    public void Jump()
    {
        
            //ForceMode2D.Impulse ���Ը� ������ �� ����մϴ�.
            rigid2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);   //Addforce ���� �ִ°�
        
    }
    //private void FixedUpdate()
    //{
    //    //Rigidbody�� ���� ���갰�� ��� Fixed���� ó���ؾ��Ѵ�.

    //    if (Input.GetKeyDown(KeyCode.Space))//Ű�ڵ带 ���ذ����� �Ѵ�. ��ư�ٿ��� �������ִ°�
    //    {
    //        //ForceMode2D.Impulse ���Ը� ������ �� ����մϴ�.
    //        rigid2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);   //Addforce ���� �ִ°�
    //    }


    //}






    //����Ƽ 2D ������ 2D Collidoer�� Rigidbody 2D�� 2D �浹 �Լ��� ����ؾ� �մϴ�.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Portal"))
        {
            Camera.main.transform.position = new Vector3(5, 0,Camera.main.transform.position.z);   //ī�޶� ��ġ�� x ������ 10 ��ŭ ��
            transform.position = new Vector3(14.5f, 0, 0); //ĳ���͵� 12.5 ��ŭ ��ġ �̵� �����
        }
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

    //���� Ǫ�� : ����Ƽ Asset �˸� SDK �� �ٿ�޾Ƽ� Ư�� �ð����� üũ�ϰ� �˸��� �����ִ� ���

    //���� Ǫ�� : ������ �ð��� ���߰� �˸��� ������ ���

    //IL2CPP�� - ����Ƽ�� ������ ��ũ���� �鿣���, �پ��� �÷����� ������Ʈ�� ������ �� Mono ��� ����� �� �ֽ��ϴ�.
    ///<summary>����ϸ� ������Ʈ�� ������ �� ����Ƽ�� �÷����� ���� ���� ���̳ʸ� ������ ����� ���� IL�ڵ带 ��ũ��Ʈ �� ��������� C++�� ��ȯ�մϴ�.
    
   //Ű������? 
   //������ ������ �����ϴ� ������ Ű�� ��ƵФ� ���ڿ���. ���� ���� ���� ���ε� Ű�� ������ ���ε尡 ���� �ʴ´�. �ѹ� ������ Ű������ �� �� �����ؾ��Ѵ�.

}
