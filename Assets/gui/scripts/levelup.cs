﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelup : MonoBehaviour {


   private int number;

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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "friend")
        {

            Destroy(gameObject);
            //var rend = GetComponent<SpriteRenderer>();
            //var box = GetComponent<BoxCollider2D>();


            //rend.enabled = false;
            //box.enabled = false;
            //riptableObject sn = gameObject.GetComponent<fondmanage>();

        }


    }


   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.tag == "friend") {
            
            number = number + 1;
            Debug.Log(number);




        if (number == 1)
        {
            
            GameObject currentprojectile1 = Instantiate(evolution1);
            currentprojectile1.transform.position = shipcontroller.posi;
             
            }

        if (number == 2)
        {

            GameObject currentprojectile2 = Instantiate(evolution2);
            currentprojectile2.transform.position = shipcontroller2.posi;
                var rend = GetComponent<SpriteRenderer>();
                var box = GetComponent<BoxCollider2D>();


                rend.enabled = false;
                box.enabled = false;
            }

        if (number == 3)
        {

            GameObject currentprojectile3 = Instantiate(evolution3);
            currentprojectile3.transform.position = vaissseau3.posi;
                var rend = GetComponent<SpriteRenderer>();
                var box = GetComponent<BoxCollider2D>();


                rend.enabled = false;
                box.enabled = false;

            }

        }
        
    */


    /* if (collision.gameObject.tag == "friend")
     {
         transformous = true;
         if (number <= 0)
         {

             GameObject currentprojectile1 = Instantiate(evolution1);
             currentprojectile1.transform.position = shipcontroller.posi;

         }

         if (number == 1)
         {

             GameObject currentprojectile2 = Instantiate(evolution2);
             currentprojectile2.transform.position = shipcontroller2.posi;

         }

         if (number == 2)
         {

             GameObject currentprojectile3 = Instantiate(evolution3);
             currentprojectile3.transform.position = vaissseau3.posi;

         }


         // Instantiate(evolution);

         //Rigidbody2D rb2 = currentprojectile2.GetComponent<Rigidbody2D>();
         // float posx = socket.transform.position.x;
         //float posy = socket.transform.position.y;
         //currentprojectile2.transform.position = new Vector2(posx, posy);


         //shipcontroller.actuallife = shipcontroller.actuallife + 50;

         var rend = GetComponent<SpriteRenderer>();
         var box = GetComponent<BoxCollider2D>();


         rend.enabled = false;
         box.enabled = false;
         //Destroy(gameObject);

     }
     */





}
