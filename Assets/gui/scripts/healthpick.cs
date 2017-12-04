using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpick : MonoBehaviour {


    // float posx;
    // float posy;
    Renderer rend;
    Vector3 mvt;
    public float speed;
    AudioSource SFX;
	// Use this for initialization
	void Start () {
        // mvt = new Vector3(transform.position.x, transform.position.y, 0);
        SFX = GetComponent<AudioSource>();
        rend = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {
        
       // posy = posy + 1;

        //transform.Rotate(0, 2,0);
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
            StartCoroutine(tarace());      
        }
    }

    IEnumerator tarace()
    {
        SFX.Play();
        var box = GetComponent<BoxCollider2D>();
        rend.enabled = false;
        box.enabled = false;
        shipcontroller.actuallife = shipcontroller.maxlife;
        shipcontroller2.actuallife2 = shipcontroller2.maxlife2;
        vaissseau3.actuallife2 = vaissseau3.maxlife2;
        vaissseaux4.actuallife2 = vaissseaux4.maxlife2;
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
