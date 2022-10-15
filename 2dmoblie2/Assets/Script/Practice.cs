using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] float speed = 1.0f;

    [SerializeField] float jumpPower = 1.0f;

    Rigidbody2D rigid2D;


    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if(x<0)
        {
            sprite.flipX = false;
        }
        else if (x<0)
        {
            sprite.flipX = true;
        }

        transform.Translate(x * speed * Time.deltaTime, 0, transform.position.z); // 이동속도 

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigid2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

        }

        

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Portal"))
        {
            Camera.main.transform.position = new Vector3(5, 0, Camera.main.transform.position.z);
            transform.position = new Vector3(14.5f, 0, 0);
        }
    }




}
