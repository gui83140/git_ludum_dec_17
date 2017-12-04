using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friendlymissile : MonoBehaviour {




    private void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Transform.Destroy(this);
        if (collision.gameObject.tag == "enemis" || collision.gameObject.tag == "bigenemis" || collision.gameObject.tag == "Laser")
        {
            Destroy(gameObject);
        }

    }


}
