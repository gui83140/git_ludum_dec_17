using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpick : MonoBehaviour {


   // float posx;
   // float posy;
    Vector3 mvt;
    public float speed;
	// Use this for initialization
	void Start () {
       // mvt = new Vector3(transform.position.x, transform.position.y, 0);
        

    }
	
	// Update is called once per frame
	void Update () {
        
       // posy = posy + 1;

        transform.Rotate(0, 2,0);
        transform.position = new Vector3(transform.position.x, transform.position.y - 1*speed, 0);
		
	}

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameobject.tag == friend)
        {

        }

    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.gameObject.tag == "friend")
        {
            shipcontroller.actuallife = shipcontroller.actuallife +50;
            shipcontroller2.actuallife2 = shipcontroller2.actuallife2 + 50;
            Destroy(gameObject);

        }
    }
}
