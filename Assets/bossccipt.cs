using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossccipt : MonoBehaviour {


    public float speedY;
    public float speedX;
    bool totheright;
    bool totheleft;

    void Start () {

        transform.position = new Vector2(0, transform.position.y);

        
	}




    void Update() {

        if (transform.position.y > 4.5) {
            transform.position = new Vector2(0, transform.position.y - 1 * speedY);
        }


        if (transform.position.x > -8 && totheright == false)

        {
            transform.position = new Vector2(transform.position.x - 1 * speedX, transform.position.y);

        }

        if (transform.position.x <= -8)
        {
            totheright = true;


        }

        if (totheright)
        {
            transform.position = new Vector2(transform.position.x + 1 * speedX, transform.position.y);

            if (transform.position.x >= 8)
            {
                totheright = false;
            }

        }





   


       /* if (transform.position.x > -8)
        { Debug.Log(transform.position.x);
            transform.position = new Vector2(transform.position.x - 1 * speedX, transform.position.y);
        }

        if (transform.position.x <= -9)
        {
            gotoleft = false;
            gotoright = true; 
            

        }

        if (transform.position.x >= 8)
        {
            gotoright = false;
            gotoleft = true;


        }


        if (gotoright = false && gotoleft)
        {
            transform.position = new Vector2(transform.position.x - 1 * speedX, transform.position.y);

        }

        if (gotoright && gotoleft == false)
        {
            transform.position = new Vector2(transform.position.x + 1 * speedX, transform.position.y);

        }

    }
}*/

}}