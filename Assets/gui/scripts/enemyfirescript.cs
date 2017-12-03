using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfirescript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {




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