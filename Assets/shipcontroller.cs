using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipcontroller : MonoBehaviour {

    public float speedmvt;
    float posy;
    float posx;
    Vector2 mvt;
	void Start () {
		
	}
	
	
	void Update () {

        posx = Input.GetAxis("Horizontal");
        posy = Input.GetAxis("Vertical");
        mvt = new Vector2(transform.position.x + posx*speedmvt, transform.position.y + posy*speedmvt);
        //mvt.x = Mathf.Clamp(mvt.x, -50f, 100f);
        transform.position = mvt;
        

        //transform.position = new Vector3(Mathf.Clamp(Time.time, 1.0F, 3.0F), 0, 0);
    }

    //public void Clamp(mvt min, mvt max);
}
