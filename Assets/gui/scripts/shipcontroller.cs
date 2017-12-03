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

    //public bool shooted;


    

   public  static float actuallife;
    public  static float maxlife;

    public float pubicmaxlife;

    bool destruction;

    //public GameObject destruction;

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

    public float firerate;
    float countime;

    float timedestruction;

    void Start()
    {
        maxlife = pubicmaxlife;
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        actuallife = maxlife;
    }


    void Update()
    {
        countime = countime + 1;

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


        







        // projectile
        if (Input.GetMouseButton(0) && countime >= firerate && destruction == false)
        {
            GameObject currentprojectile1 = Instantiate(projectile);
            Rigidbody2D rb1 = currentprojectile1.GetComponent<Rigidbody2D>();
            canon1 = debutprojectile1.transform.position.x;
            canon11 = debutprojectile1.transform.position.y;
            currentprojectile1.transform.position = new Vector2(canon1, canon11);
           // shooted = true;
            Vector2 haut1 = new Vector2(canon1, 250f);
            rb1.AddForce(haut1 * speedlaser, ForceMode2D.Impulse);

            GameObject currentprojectile2 = Instantiate(projectile);
            Rigidbody2D rb2 = currentprojectile2.GetComponent<Rigidbody2D>();
            canon2 = debutprojectile2.transform.position.x;
            canon22 = debutprojectile2.transform.position.y;
            currentprojectile2.transform.position = new Vector2(canon2, canon22);
            //shooted = true;
            Vector2 haut2 = new Vector2(canon2, 250f);
            rb2.AddForce(haut2 * speedlaser, ForceMode2D.Impulse);

            countime = 0;

        }
        // animations
        if (mvt != new Vector2(0, 0))
        {
            anim.SetBool("move", true);
        }

        else
        {
            anim.SetBool("move", false);

        }

        if (destruction)
        {
            timedestruction = timedestruction + 1;
            rb2d.constraints = RigidbodyConstraints2D.FreezePosition;
            if (timedestruction >= 60)
            {
                Destroy(gameObject);

            }

        }

       
    }

    //destruction vaisseau
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Transform.Destroy(this);
        if (collision.gameObject.tag == "enemisfire")
        {

            actuallife = actuallife - 10f;

           // barredevie.healtbarre = barredevie.healtbarre - 10;
            //Instantiate(destruction);

            if (actuallife <= 0)
            {



                anim.SetBool("explosion", true);
                destruction = true;
            }
            //Destroy(gameObject);

            // Destroy(gameObject);
        }

        if (collision.gameObject.tag == "levelup")
        {
            Debug.Log("bite");
            //Destroy(gameObject);
        }

        if (collision.gameObject.tag == "enemis")
        {

            actuallife = actuallife - 100f;
            if (actuallife <= 0)
            {



                anim.SetBool("explosion", true);
                destruction = true;
            }
            
        }
    }
}



    


        

    

   

