using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Threading;

public class TouchManager : MonoBehaviour {

    bool isJump = true;
    bool isDead = false;
    int idMove = 0;

    //float directionX;
    //Rigidbody2D rb;

    /*public void Size()
    {
        Texture2D texture = new Texture2D(128, 128);
        GetComponent<Renderer>().material.mainTexture = texture;

        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                Color color = ((x & y) != 0 ? Color.white : Color.gray);
                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
    }*/
    private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        //directionX = CrossPlatformInputManager.GetAxis("Horizontal");
       //rb.velocity = new Vector2(directionX * 10, 0);
            
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
            //Size();
        }
        
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
            //Size();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            //Size();
        }

        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            Idle();
            //Size();
        }

        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Idle();
            //Size();
        }

        Move();
        Dead();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(isJump)
        {
            isJump = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isJump = true;
    }

    public void MoveRight()
    {
        idMove = 1;
    }

    public void MoveLeft()
    {
        idMove = 2;
    }

    private void Move()
    {
        if(idMove == 1 && !isDead)
        {
            transform.Translate(1 * Time.deltaTime * 5f, 0, 0);
            //transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if(idMove == 2 && !isDead)
        {
            transform.Translate(-1 * Time.deltaTime * 5f, 0, 0);
            //transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    public void Jump()
    {
        if(!isJump)
        {
            if (GetComponent<Rigidbody2D>().velocity.y < 1)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 300f);
            }
        }
    }

    public void Idle()
    {
        if(!isJump)
        {

        }

        idMove = 0;
    }

    private void Dead()
    {
        if(!isDead)
        {
            if (transform.position.y < -10f)
            {
                isDead = true;
            }
        }
    }

    public void Thread()
    {

    }

}
