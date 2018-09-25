using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rigid;
    public float moveSpeed;
    public float moveForceMultiplier = 50;
    public float jumpPower;
    bool isJumpFlag;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }

    /// <summary>
    /// 移動処理
    /// </summary>
    public void Move()
    {
        Vector2 moveVector = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, 0);
        Vector2 rigidVelocity = new Vector2(rigid.velocity.x, 0);
        rigid.AddForce(moveForceMultiplier * (moveVector - rigidVelocity));
    }

    public void Jump()
    {
        if(isJumpFlag)
        {
            isJumpFlag = false;
            rigid.AddForce(Vector2.up * jumpPower);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumpFlag = true;
        }
    }

}
