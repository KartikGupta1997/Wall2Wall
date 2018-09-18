using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb;

    int JumpX = 3;
    int JumpY = 9;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        

        if (Input.GetMouseButtonDown(0)) {
            //if ball goes in +x, keep moving in +x. if not, move in -x. 
            //When the ball hits the wall, it bounces in opposite direction. 
            //So, the direction changes because of hitting the wall
            if (rb.velocity.x >= 0)
            {
                rb.velocity = new Vector2(JumpX, JumpY);
            }
            else {

                rb.velocity = new Vector2(-JumpX, JumpY);
            }
        }
	}
}
