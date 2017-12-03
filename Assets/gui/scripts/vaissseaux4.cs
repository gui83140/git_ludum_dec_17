using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaissseaux4 : MonoBehaviour {

    public static float actuallife2;
    public static float maxlife2;
    public static Vector3 posi;

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
    public GameObject debutprojectile3;
    public GameObject debutprojectile4;
    public GameObject debutprojectile5;
    public GameObject debutprojectile6;
    float canon1; float canon11;
    float canon2; float canon22;
    float canon3; float canon33;
    float canon4; float canon44;
    float canon5; float canon55;
    float canon6; float canon66;
    public AudioClip[] Clips;
    private AudioSource[] audioSources;
    public float Volume0, Volume1;



    public float speedlaser;

    public float firerate;
    float countime;

    float timedestruction;

    void Start()
    {
        maxlife2 = pubicmaxlife;
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        actuallife2 = maxlife2;
        audioSources = new AudioSource[Clips.Length];
        int i = 0;
        while (i < Clips.Length)
        {
            GameObject child = new GameObject("Player");

            child.transform.parent = gameObject.transform;

            audioSources[i] = child.AddComponent<AudioSource>() as AudioSource;

            audioSources[i].clip = Clips[i];

            i++;
        }
        audioSources[0].volume = Volume0;
        audioSources[1].volume = Volume1;
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

        posi = transform.position;










        // projectile
        if ((Input.GetMouseButton(0) || Input.GetButton("Jump")) && countime >= firerate && destruction == false)
        {
            audioSources[0].Play();
            GameObject currentprojectile1 = Instantiate(projectile);
            Rigidbody2D rb1 = currentprojectile1.GetComponent<Rigidbody2D>();
            canon1 = debutprojectile1.transform.position.x;
            canon11 = debutprojectile1.transform.position.y;
            currentprojectile1.transform.position = new Vector2(canon1, canon11);
            // shooted = true;
            //Vector2 haut1 = new Vector2(canon1, 250f);
            //rb1.AddForce(haut1 * speedlaser, ForceMode2D.Impulse);
            rb1.AddForce(transform.up * speedlaser, ForceMode2D.Impulse);


            GameObject currentprojectile2 = Instantiate(projectile);
            Rigidbody2D rb2 = currentprojectile2.GetComponent<Rigidbody2D>();
            canon2 = debutprojectile2.transform.position.x;
            canon22 = debutprojectile2.transform.position.y;
            currentprojectile2.transform.position = new Vector2(canon2, canon22);
            //shooted = true;
            //Vector2 haut2 = new Vector2(canon2, 250f);
            // rb2.AddForce(haut2 * speedlaser, ForceMode2D.Impulse);
            rb2.AddForce(transform.up * speedlaser, ForceMode2D.Impulse);


            GameObject currentprojectile3 = Instantiate(projectile);
            Rigidbody2D rb3 = currentprojectile3.GetComponent<Rigidbody2D>();
            canon3 = debutprojectile3.transform.position.x;
            canon33 = debutprojectile3.transform.position.y;
            currentprojectile3.transform.position = new Vector2(canon3, canon33);
            currentprojectile3.transform.Rotate(0, 0, 45);
            //shooted = true;
            // Vector2 haut3 = new Vector2(canon3, 250f);
            //rb3.AddForce(haut3 * speedlaser, ForceMode2D.Impulse);
            //rb3.AddForce(transform.up * speedlaser, ForceMode2D.Impulse);
            rb3.AddForce(transform.up * speedlaser / 2 + (-transform.right * speedlaser / 2), ForceMode2D.Impulse);


            GameObject currentprojectile4 = Instantiate(projectile);
            Rigidbody2D rb4 = currentprojectile4.GetComponent<Rigidbody2D>();
            canon4 = debutprojectile4.transform.position.x;
            canon44 = debutprojectile4.transform.position.y;
            currentprojectile4.transform.position = new Vector2(canon4, canon44);
            currentprojectile4.transform.Rotate(0, 0, -45);



            //shooted = true;
            // Vector2 haut3 = new Vector2(canon3, 250f);
            //rb3.AddForce(haut3 * speedlaser, ForceMode2D.Impulse);
            rb4.AddForce(transform.up * speedlaser / 2 + (transform.right * speedlaser / 2), ForceMode2D.Impulse);




            GameObject currentprojectile5 = Instantiate(projectile);
            Rigidbody2D rb5 = currentprojectile5.GetComponent<Rigidbody2D>();
            canon5 = debutprojectile5.transform.position.x;
            canon55 = debutprojectile5.transform.position.y;
            currentprojectile5.transform.position = new Vector2(canon5, canon55);
            currentprojectile5.transform.Rotate(0, 0, 45);
            //shooted = true;
            // Vector2 haut3 = new Vector2(canon3, 250f);
            //rb3.AddForce(haut3 * speedlaser, ForceMode2D.Impulse);
            //rb3.AddForce(transform.up * speedlaser, ForceMode2D.Impulse);
            rb5.AddForce(transform.up * speedlaser / 2 + (-transform.right * speedlaser / 2), ForceMode2D.Impulse);


            GameObject currentprojectile6 = Instantiate(projectile);
            Rigidbody2D rb6 = currentprojectile6.GetComponent<Rigidbody2D>();
            canon6 = debutprojectile6.transform.position.x;
            canon66 = debutprojectile6.transform.position.y;
            currentprojectile6.transform.position = new Vector2(canon6, canon66);
            currentprojectile6.transform.Rotate(0, 0, -45);



            //shooted = true;
            // Vector2 haut3 = new Vector2(canon3, 250f);
            //rb3.AddForce(haut3 * speedlaser, ForceMode2D.Impulse);
            rb6.AddForce(transform.up * speedlaser / 2 + (transform.right * speedlaser / 2), ForceMode2D.Impulse);



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
            if (timedestruction >= 40)
            {
                Destroy(gameObject);
                FindObjectOfType<GameManager>().EndGame();
            }

        }


    }

    //destruction vaisseau
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Transform.Destroy(this);
        if (collision.gameObject.tag == "enemisfire")
        {

            actuallife2 = actuallife2 - 10f;
           
            // barredevie.healtbarre = barredevie.healtbarre - 10;
            //Instantiate(destruction);

            if (actuallife2 <= 0)
            {



                anim.SetBool("explosion", true);
                destruction = true;
            }
            //Destroy(gameObject);

            // Destroy(gameObject);
        }

        if (collision.gameObject.tag == "levelup")
        {
            Debug.Log("joie");

            //Debug.Log("bite");
            // Destroy(gameObject);
        }

        if (collision.gameObject.tag == "enemis")
        {

            actuallife2 = actuallife2 - 10000f;
            if (actuallife2 <= 0)
            {


                audioSources[1].Play();
                anim.SetBool("explosion", true);
                destruction = true;
            }

        }
    }
}
