using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

    public GameObject triangleObj;
	// Use this for initialization
	void Start () {

        initObstacles();
        	
	}

    void initObstacles() {

        //this foreach loop will destroy all the obstacles from the previous loop for loop (destroys obstacles from the start function in first iteration)
        foreach (Transform child in transform) {
            GameObject.Destroy(child.gameObject);
        }
        for (int i=0; i<12; i++)
        {
            int randomY = Random.Range(-6, 7); 

            //randomly selected numbers from the range will instantiate an obstacle there
            GameObject tempObj = Instantiate(triangleObj, new Vector2(transform.position.x, randomY), Quaternion.identity);
            
            //all the instantiated gameobjects will become the child of the wall, using the line of code below
            tempObj.transform.SetParent(transform);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Name:" + collision.gameObject.name);
        initObstacles();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
