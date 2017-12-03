using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chassabomba : MonoBehaviour {

    float posx;
    float posy;
    public float speedY;
    public float speedX;
    public float range;


    // Use this for initialization
    void Start () {
        posx = transform.position.x;
        posy = transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y>8)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 1 * speedY);
            //transform.position.y = transform.position.y + 1 speed;


        }

        if (transform.position.x <=range)
        {


        }

    }
}
