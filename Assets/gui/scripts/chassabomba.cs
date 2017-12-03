using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chassabomba : MonoBehaviour {

    public GameObject target;

    public GameObject projectile;

    float timedestruction;

    public GameObject socket1;
    public GameObject socket2;
    public GameObject socket3;

    Rigidbody2D rb2d;

    public float enemislife;
    public float speedfire;
    private bool destruction;
    private bool pause1;
    private bool pause2;
    private bool pause3;
    private bool totheright;
    bool onscreen;


    float firerate1;
    float firerate2;
    float firerate3;

    public float truefrirerate1;
    public float truefrirerate2;
    public float truefrirerate3;

    float canon1; float canon11;
    float canon2; float canon22;
    float canon3; float canon33;

    public float speedY;
    public float speedX;

    private Animator anim;

    // Use this for initialization
    void Start() {

        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        firerate1 = 0;
        firerate2 = 0;
        firerate3 = 0;
    }

    // Update is called once per frame
    void Update() {



        if (firerate1 <= 25 && destruction == false && pause1 == false && onscreen && destruction == false) {
            firerate1 = firerate1 + truefrirerate1;

            GameObject currentprojectile1 = Instantiate(projectile);
            Rigidbody2D rb1 = currentprojectile1.GetComponent<Rigidbody2D>();
            canon1 = socket1.transform.position.x;
            canon11 = socket1.transform.position.y;
            currentprojectile1.transform.position = new Vector2(canon1, canon11);
            rb1.AddForce(-transform.up * speedfire, ForceMode2D.Impulse);

            if (firerate1 >= 24)

            {
                pause1 = true;


            }

        }

        if (firerate2 <= 25 && destruction == false && pause2 == false && onscreen && destruction == false)
        {
            firerate2 = firerate2 + truefrirerate2;

            GameObject currentprojectile2 = Instantiate(projectile);
            Rigidbody2D rb2 = currentprojectile2.GetComponent<Rigidbody2D>();
            canon2 = socket2.transform.position.x;
            canon22 = socket2.transform.position.y;
            currentprojectile2.transform.position = new Vector2(canon2, canon22);
            rb2.AddForce(-transform.up * speedfire, ForceMode2D.Impulse);

            if (firerate2 >= 24)

            {
                pause2 = true;


            }


        }

        if (firerate3 <= 25 && destruction == false && pause3 == false && onscreen && destruction == false)
        {
            firerate3 = firerate3 + truefrirerate3;

            GameObject currentprojectile3 = Instantiate(projectile);
            Rigidbody2D rb3 = currentprojectile3.GetComponent<Rigidbody2D>();
            canon3 = socket3.transform.position.x;
            canon33 = socket3.transform.position.y;
            currentprojectile3.transform.position = new Vector2(canon3, canon33);
            rb3.AddForce(-transform.up * speedfire, ForceMode2D.Impulse);

            if (firerate3 >= 24)

            {
                pause3 = true;


            }


        }










        if (pause1 == true) {
            firerate1 = firerate1 - truefrirerate1 / 30;
            
        }


        if (pause2 == true)
        {
            firerate2 = firerate2 - truefrirerate2 / 50;
            

        }

        if (pause3 == true)
        {
            firerate3 = firerate3 - truefrirerate3 / 70;
            
        }

        if (firerate1 <= 0)
        {
            pause1 = false;
           
          

            firerate1 = 1 + truefrirerate1 / 30;

        }

        if (firerate2 <= 0)
        {
            
            pause2 = false;
         

            firerate2 = 1 + truefrirerate2 / 30;

        }

        if (firerate3 <= 0)
        {
           
            pause3 = false;

            firerate3 = 1 + truefrirerate3 / 30;

        }






        if (transform.position.y > target.transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 1 * speedY);
        }

        if (transform.position.x > -14 && transform.position.y <= target.transform.position.y && totheright == false)

        {
            transform.position = new Vector2(transform.position.x - 1 * speedX, transform.position.y);

        }

        if (transform.position.x <= -14 && transform.position.y < target.transform.position.y)
        {
            totheright = true;


        }

        if (totheright)
        {
            transform.position = new Vector2(transform.position.x + 1 * speedX, transform.position.y);

            if (transform.position.x >= 14)
            {
                totheright = false;
            }
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


        
        if (collision.gameObject.tag == "onscreen")

        {
        
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

        if (collision.gameObject.tag == "flumissile")
        {
            enemislife = enemislife - 0.05f;
            Debug.Log(enemislife);
            if (enemislife <= 0)
            {
                anim.SetBool("explosion", true);

                destruction = true;



            }



        }
    }

}
