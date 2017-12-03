using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretscript : MonoBehaviour
{



    float timedestruction;
    bool destruction;
    Rigidbody2D rb2d;

    public float enemislife;
        
    bool onscreen;
    
    public float speedfire;
    public GameObject projectile;
    public GameObject socket1;
    public GameObject socket2;
    float canon1; float canon11;
    float canon2; float canon22;

    public float speedrotato;
    public float speedmove;

    private Animator anim;
    float posy;
    float posx;
    float firerate;
    public float truefrirerate;

    void Start()
    {
        firerate = 50;
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("fire", false); 
         firerate = firerate + truefrirerate;
        posy = transform.position.y;
        posx = transform.position.x;
        transform.Rotate(0, 0, speedrotato);
        transform.position = new Vector2(posx, posy - speedmove);

        if (firerate >= 50 && onscreen == true && destruction == false)
        {

            anim.SetBool("fire", true);
            GameObject currentprojectile1 = Instantiate(projectile);
            Rigidbody2D rb1 = currentprojectile1.GetComponent<Rigidbody2D>();
            canon1 = socket1.transform.position.x;
            canon11 = socket1.transform.position.y;
            currentprojectile1.transform.position = new Vector2(canon1, canon11);

            //currentprojectile1.transform.Translate(transform.forward * Time.deltaTime);
            //rb1.AddForce(socket1.transform.forward * speedfire, ForceMode2D.Impulse);
            rb1.AddForce(-transform.up * speedfire, ForceMode2D.Impulse);



            GameObject currentprojectile2 = Instantiate(projectile);
            Rigidbody2D rb2 = currentprojectile2.GetComponent<Rigidbody2D>();
            canon2 = socket2.transform.position.x;
            canon22 = socket2.transform.position.y;
            currentprojectile2.transform.position = new Vector2(canon2, canon22);


            rb2.AddForce(-transform.up * speedfire, ForceMode2D.Impulse);


            firerate = 0;
        }



        if (destruction)
        {
            timedestruction = timedestruction + 1;
            rb2d.constraints = RigidbodyConstraints2D.FreezePosition;
            
            if (timedestruction >= 40)
            {
                Destroy(gameObject);

            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

       
        //Transform.Destroy(this);
        if (collision.gameObject.tag == "onscreen")

        {
            //Debug.Log("zizi");
            onscreen = true;
            

        }

        if (collision.gameObject.tag == "outscreen")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "friend" || collision.gameObject.tag == "missilefriend")
        {
            enemislife = enemislife - 1;

            if (enemislife <= 0)
            {
                anim.SetBool("explosion", true);
                destruction = true;

            }

           
            
        }
    }

   
}