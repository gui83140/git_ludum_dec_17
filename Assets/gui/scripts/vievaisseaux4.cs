using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class vievaisseaux4 : MonoBehaviour {

    Image greenlife;
    float healtbarre;
    private float maxhealtbarre;

    public GameObject following;
    // Use this for initialization
    void Start()
    {

        healtbarre = vaissseaux4.maxlife2;
        
        greenlife = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = (following.transform.position + new Vector2(0,10));
        transform.position = new Vector3(following.transform.position.x, following.transform.position.y - 2.5f, 0);
        healtbarre = vaissseaux4.actuallife2;

        maxhealtbarre = vaissseaux4.maxlife2;
        greenlife.fillAmount = healtbarre / maxhealtbarre;
        



    }
}
