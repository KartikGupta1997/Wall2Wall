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
        int i;
        for (i=0; i<12; i++)
        {
            int randomY = Random.Range(-6, 7); 
<<<<<<< HEAD

            //randomly selected numbers from the range will instantiate an obstacle there
=======
>>>>>>> parent of 054d05a... added autospawn of obstacles
            GameObject tempObj = Instantiate(triangleObj, new Vector2(transform.position.x, randomY), Quaternion.identity);
            
            //all the instantiated gameobjects will become the child of the wall, using the line of code below
            tempObj.transform.SetParent(transform);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
