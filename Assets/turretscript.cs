﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretscript : MonoBehaviour
{

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

    void Start()
    {
        firerate = 50;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("fire", false);
        firerate = firerate+1 ;
        posy = transform.position.y;
        posx = transform.position.x;
        transform.Rotate(0, 0, speedrotato);
        transform.position = new Vector2(posx, posy - speedmove);

        if (firerate >= 50 && onscreen == true)
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

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

       
        //Transform.Destroy(this);
        if (collision.gameObject.tag == "onscreen")

        {
            Debug.Log("zizi");
            onscreen = true;
            

        }

        if (collision.gameObject.tag == "outscreen")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "friend")
        {
            
            Destroy(gameObject);
        }
    }

   
}