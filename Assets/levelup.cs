using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelup : MonoBehaviour {

    public GameObject evolution;
    public GameObject socket;

    Vector3 mvt;
    public float speed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 2, 0);
        transform.position = new Vector3(transform.position.x, transform.position.y - 1 * speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.gameObject.tag == "friend")
        {
            Instantiate(evolution);
            GameObject currentprojectile2 = Instantiate(evolution);
            Rigidbody2D rb2 = currentprojectile2.GetComponent<Rigidbody2D>();
            float posx = socket.transform.position.x;
            float posy = socket.transform.position.y;
            currentprojectile2.transform.position = new Vector2(posx, posy);


            //shipcontroller.actuallife = shipcontroller.actuallife + 50;
            Destroy(gameObject);

        }
    }



}
