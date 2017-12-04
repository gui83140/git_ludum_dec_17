using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSocket : MonoBehaviour {

    public GameObject Lazer;


    bool lazerous;

    BoxCollider2D pol;

    void Start() {
        Debug.Log("blaz");


        pol = GetComponent<BoxCollider2D>();
        pol.enabled = false;
        StartCoroutine(blabla());

    }

    IEnumerator blabla()
    {
        yield return new WaitForSeconds(.8f);
        pol.enabled = true;
    }


    void Update()

    {
        Debug.Log("blaz");

        lazerous = bossccipt.lazer1;
        transform.position = bossccipt.posboss;

       
        Debug.Log(lazerous);

        if (lazerous)
        {
            Laser();
           

        }


    }


    void Laser()
    {
        //anim.SetBool("Attack", true);
        StartCoroutine(Jaja());

    }

    void TrueLaser()
    {
        GameObject currentprojectile1 = Instantiate(Lazer);
        currentprojectile1.transform.position = bossccipt.posboss - new Vector3(5,-10);
        //currentprojectile1.transform.parent = socket1.transform;
        //canon1 = socket1.transform.position.x;
        //canon11 = socket1.transform.position.y - 15f;
        //currentprojectile1.transform.position = new Vector2(canon1, canon11);
        Destroy(currentprojectile1, 4f);

        GameObject currentprojectile2 = Instantiate(Lazer);
        currentprojectile2.transform.position = bossccipt.posboss + new Vector3(-5, -10); ;
        //currentprojectile2.transform.parent = socket2.transform;
        //canon2 = socket2.transform.position.x;
        //canon22 = socket2.transform.position.y - 15f;
        //currentprojectile2.transform.position = new Vector2(canon2, canon22);
        Destroy(currentprojectile2, 4f);

        StartCoroutine(Juju());
    }
    IEnumerator Juju()
    {
        yield return new WaitForSeconds(4f);
        //anim.SetBool("Attack", false);
    }

    IEnumerator Jaja()
    {
        yield return new WaitForSeconds(1f);
        TrueLaser();
    }
}
