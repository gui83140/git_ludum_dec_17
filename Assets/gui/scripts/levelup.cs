using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelup : MonoBehaviour {




   private int number;

    Vector3 mvt;
    public float speed;
    public AudioClip[] Clips;
    private AudioSource[] audioSources;
    public float Volume1, Volume0;




    // Use this for initialization
    void Start () {
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
    }
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(transform.position.x, transform.position.y - 1 * speed, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "friend")
        {
            audioSources[0].volume = Volume0;
            audioSources[0].Play();
            audioSources[1].volume = Volume1;
            audioSources[1].Play();

            var rend = GetComponent<SpriteRenderer>();
            var box = GetComponent<BoxCollider2D>();


            shipcontroller.actuallife = shipcontroller.actuallife + shipcontroller.maxlife / 4 ;
            shipcontroller2.actuallife2 = shipcontroller2.actuallife2+  shipcontroller2.maxlife2/4;
            vaissseau3.actuallife2 = vaissseau3.actuallife2 + vaissseau3.maxlife2/4;
            vaissseaux4.actuallife2 = vaissseaux4.actuallife2 + vaissseaux4.maxlife2/4;


            rend.enabled = false;
            box.enabled = false;
            Destroy(gameObject, 2f);

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
