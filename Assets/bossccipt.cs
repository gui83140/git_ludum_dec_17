using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossccipt : MonoBehaviour {

    public static bool lazer1;

    public static Vector3 posboss;

    public float speedY;
    public float speedX;
    public float FirePower;
    bool totheright;
    bool totheleft;
    public GameObject socket1;
    public GameObject socket2;
    public GameObject socket3;
    public GameObject socket4;
    public GameObject socket5;
    public GameObject socket6;
    public GameObject Lazer;
    public GameObject projectile;
    public int NbSalve1;
    public int NbSalve2;
    public float enemislife;
    bool destruction;
    AudioSource audioSource;
    public AudioClip bite;
    bool soundplayed;
    Renderer renderers;
    public Color[] colors;



    public bool Attaque2;
    public bool Attaque3;
    public bool ChooseAttack;

    float canon1, canon11, canon2, canon22, canon3, canon33, canon4, canon44, canon5, canon55, canon6, canon66;
    Animator anim;

    void Start () {

        transform.position = new Vector2(0, transform.position.y);
        anim = GetComponent<Animator>();
        renderers = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        soundplayed = true;

    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "onscreen")

        {
            StartCoroutine(BossHere());
        }

        if (collision.gameObject.tag == "friend" || collision.gameObject.tag == "missilefriend")
        {
            StartCoroutine(Flick());
            enemislife = enemislife - 1;
        }

        if (collision.gameObject.tag == "flumissile")
        {
            StartCoroutine(Flick());
            enemislife = enemislife - 0.05f;

        }


        if (enemislife <= 0)
        {
            FindObjectOfType<GameManager>().BossDefeated();
            ChooseAttack = false;
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            StartCoroutine(DeathBoss());

        }
    }

    IEnumerator DeathBoss()
    {
        audioSource.PlayOneShot(bite, 0.7f);
        audioSource.pitch = (Random.Range(0.4f, 0.9f));
        anim.SetBool("explosion", true);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    IEnumerator Flick()
    {
        renderers.material.color = colors[0];
        yield return new WaitForSeconds(.1f);
        renderers.material.color = colors[1];

    }

    IEnumerator BossHere()
    {
        yield return new WaitForSeconds(3.5f);
        ChooseAttack = true;
    }
    void Update()
    {
        if (transform.position.y > 4.5)
        {
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

        posboss = transform.position;

        if (ChooseAttack)
        {
            ChooseAttack = false;
            StartCoroutine(AttackAction());
          
        }
       /* if (destruction)
        {
            timedestruction = timedestruction + 1;
            rb2d.constraints = RigidbodyConstraints2D.FreezePosition;

            if (timedestruction >= 40)
            {
                Destroy(gameObject);

            }

        }*/
    }

    IEnumerator AttackAction()
    {     
        bool Attaque1 = (Random.value < .5f);
        bool Attaque2 = (Random.value < .5f);
        bool Attaque3 = (Random.value < .5f);
        Debug.Log(Attaque1);
        Debug.Log(Attaque2);
        Debug.Log(Attaque3);

        if (Attaque1 & !Attaque2 & !Attaque3)
        {          
            Laser();
            Attaque1 = false;
        }


        if (Attaque2 & !Attaque1 & !Attaque3)
        {
            StartCoroutine(Shoot1());
            Attaque2 = false;
        }



        if (Attaque3 & !Attaque1 & !Attaque2)
        {
            StartCoroutine(Shoot2());
            Attaque3 = false;
        }

        if (Attaque1 & Attaque2 & !Attaque3)
        {
            StartCoroutine(Shoot1());
            Attaque2 = false;
        }

        if (Attaque1 & !Attaque2 & Attaque3)
        {
            Laser();
            Attaque1 = false;
        }


        if (Attaque2 & !Attaque1 & Attaque3)
        {
            StartCoroutine(Shoot2());
            Attaque3 = false;
        }

        if (Attaque2 & Attaque3 & Attaque1)
        {
            StartCoroutine(Shoot1());
            Attaque2 = false;
        }

        if (!Attaque2 & !Attaque3 & !Attaque1)
        {
            Laser();
            Attaque1 = false;
        }
        yield return new WaitForSeconds(8f);
        ChooseAttack = true;
    }
    void Shoot()
    {
        GameObject currentprojectile3 = Instantiate(projectile);
        Rigidbody2D rb1 = currentprojectile3.GetComponent<Rigidbody2D>();
        canon3 = socket3.transform.position.x;
        canon33 = socket3.transform.position.y;
        currentprojectile3.transform.position = new Vector2(canon3, canon33);
        rb1.AddForce(-transform.up * FirePower, ForceMode2D.Impulse);

        GameObject currentprojectile4 = Instantiate(projectile);
        Rigidbody2D rb2 = currentprojectile4.GetComponent<Rigidbody2D>();
        canon4 = socket4.transform.position.x;
        canon44 = socket4.transform.position.y;
        currentprojectile4.transform.position = new Vector2(canon4, canon44);
        rb2.AddForce(-transform.up * FirePower, ForceMode2D.Impulse);

        GameObject currentprojectile5 = Instantiate(projectile);
        Rigidbody2D rb3 = currentprojectile5.GetComponent<Rigidbody2D>();
        canon5 = socket5.transform.position.x;
        canon55 = socket5.transform.position.y;
        currentprojectile5.transform.position = new Vector2(canon5, canon55);
        rb3.AddForce(-transform.up * FirePower, ForceMode2D.Impulse);

        GameObject currentprojectile6 = Instantiate(projectile);
        Rigidbody2D rb4 = currentprojectile6.GetComponent<Rigidbody2D>();
        canon6 = socket6.transform.position.x;
        canon66 = socket6.transform.position.y;
        currentprojectile6.transform.position = new Vector2(canon6, canon66);
        rb4.AddForce(-transform.up * FirePower, ForceMode2D.Impulse);
    }

    IEnumerator Shoot1()
    {
        for (int i = 0; i < NbSalve1; i++)
        {
            yield return new WaitForSeconds(.3f);
            Shoot();
        }
    }

    IEnumerator Shoot2()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int e = 0; e < NbSalve2; e++)
            {
                yield return new WaitForSeconds(.01f);
                Shoot();
            }
            yield return new WaitForSeconds(1f);
        } 
    }

   void Laser()
    {
        anim.SetBool("Attack", true);
        StartCoroutine(Jaja());
        
    }

    void TrueLaser()
    {
        GameObject currentprojectile1 = Instantiate(Lazer);
        currentprojectile1.transform.parent = socket1.transform;
        canon1 = socket1.transform.position.x;
        canon11 = socket1.transform.position.y - 15f;
        currentprojectile1.transform.position = new Vector2(canon1, canon11);
        Destroy(currentprojectile1, 4f);

        GameObject currentprojectile2 = Instantiate(Lazer);
        currentprojectile2.transform.parent = socket2.transform;
        canon2 = socket2.transform.position.x;
        canon22 = socket2.transform.position.y - 15f;
        currentprojectile2.transform.position = new Vector2(canon2, canon22);
        Destroy(currentprojectile2, 4f);

        StartCoroutine(Juju());
    }
    IEnumerator Juju()
    {
        yield return new WaitForSeconds(4f);
        anim.SetBool("Attack", false);
    }

    IEnumerator Jaja()
    {
        yield return new WaitForSeconds(1f);
        TrueLaser();
    }
}