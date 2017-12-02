using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipcontroller : MonoBehaviour {
    /* marche avec position
    public float speedmvt;
    float posy;
    float posx;
    Vector2 mvt;
    Rigidbody2D rb;
    */

        /* marche avec adforce
    float movehorizon;
    float moveverti;
    Vector2 mvt;
    Rigidbody2D rb2d;
    public float speed;
    */

    float movehorizon;
    float moveverti;
    Vector2 mvt;
    Rigidbody2D rb2d;
    public float speed;

    public GameObject projectile;
    public GameObject debutprojectile;
    float canon;
    Rigidbody2D rb2dcanon;

    void Start () {
        rb2d = GetComponent<Rigidbody2D>();

    }
	
	
	void Update () {
        /*marche avec position
          posx = Input.GetAxis("Horizontal");
          posy = Input.GetAxis("Vertical");
          mvt = new Vector2(transform.position.x + posx*speedmvt, transform.position.y + posy*speedmvt);
          transform.position = mvt;
          */

        /* marche avec addforce
         movehorizon = Input.GetAxis("Horizontal");
         moveverti = Input.GetAxis("Vertical");
         mvt = new Vector2(movehorizon, moveverti);
         rb2d.AddForce(mvt * speed);
         */

        // mouvement ok
        movehorizon = Input.GetAxis("Horizontal");
        moveverti = Input.GetAxis("Vertical");
        mvt = new Vector2(movehorizon*speed, moveverti*speed);
        rb2d.velocity = mvt;

        // projectile
        if ( Input.GetMouseButtonDown(0))
        {
            GameObject currentprojectile = Instantiate(projectile);
            canon = debutprojectile.transform.position.x;
            currentprojectile.transform.position = new Vector2 (canon, 0);



        }



        

    }

   
}
