using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject WallBounceEffectObj;

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
            } else {
                rb.velocity = new Vector2(-JumpX, JumpY);
            }
        }    
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall") {
            //we create a clone object of the prefab, so that the prefab from asset 
            //does not get destroyed when we use destroy method 
            //collision.contacts[0].point gives the position coordinates of the contact between wall and player ball
            GameObject effectObj = Instantiate(WallBounceEffectObj, collision.contacts[0].point, Quaternion.identity );
            Destroy(effectObj, 0.3f);
        }
    }

}
