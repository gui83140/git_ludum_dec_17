using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSocket : MonoBehaviour {

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

}
