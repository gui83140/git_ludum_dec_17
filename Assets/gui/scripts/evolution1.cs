using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evolution1 : MonoBehaviour
{


    public GameObject revolution1;

    Vector3 mvt;
    public float speed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 2, 0);
        transform.position = new Vector3(transform.position.x, transform.position.y - 1 * speed, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "friend")
        {
            GameObject currentprojectile1 = Instantiate(revolution1);
            currentprojectile1.transform.position = shipcontroller.posi;

            Destroy(gameObject);

        }

    }

}