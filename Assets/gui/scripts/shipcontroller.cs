using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipcontroller : MonoBehaviour
{
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
    private Animator anim;
    Rigidbody2D rb2d;
    public float speed;

    public GameObject projectile;
    public GameObject debutprojectile1;
    public GameObject debutprojectile2;
    float canon1; float canon11;
    float canon2; float canon22;
    public float speedlaser;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
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
        mvt = new Vector2(movehorizon * speed, moveverti * speed);
        rb2d.velocity = mvt;



        // animations







        // projectile
        if (Input.GetMouseButtonDown(0))
        {
            GameObject currentprojectile1 = Instantiate(projectile);
            Rigidbody2D rb1 = currentprojectile1.GetComponent<Rigidbody2D>();
            canon1 = debutprojectile1.transform.position.x;
            canon11 = debutprojectile1.transform.position.y;
            currentprojectile1.transform.position = new Vector2(canon1, canon11);
            Vector2 haut1 = new Vector2(canon1, 250f);
            rb1.AddForce(haut1 * speedlaser, ForceMode2D.Impulse);

            GameObject currentprojectile2 = Instantiate(projectile);
            Rigidbody2D rb2 = currentprojectile2.GetComponent<Rigidbody2D>();
            canon2 = debutprojectile2.transform.position.x;
            canon22 = debutprojectile2.transform.position.y;
            currentprojectile2.transform.position = new Vector2(canon2, canon22);
            Vector2 haut2 = new Vector2(canon2, 250f);
            rb2.AddForce(haut2 * speedlaser, ForceMode2D.Impulse);


        }

        if (rb2d.velocity != new Vector2(0, 0))
        {
            anim.SetBool("move", true);
        }

        else
        {
            anim.SetBool("move", false);

        }
    }

}



    


        

    

   

