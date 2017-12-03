using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class vievaisseaux3 : MonoBehaviour {

    Image greenlife;
    float healtbarre;
    private float maxhealtbarre;

    public GameObject following;
    // Use this for initialization
    void Start()
    {

        healtbarre = vaissseau3.maxlife2;

        greenlife = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = (following.transform.position + new Vector2(0,10));
        transform.position = new Vector3(following.transform.position.x, following.transform.position.y - 1, 0);
        healtbarre = vaissseau3.actuallife2;
        //healtbarre = healtbarre - 1;

        maxhealtbarre = vaissseau3.maxlife2;
        greenlife.fillAmount = healtbarre / maxhealtbarre;
       // Debug.Log(greenlife.fillAmount);



    }
}
