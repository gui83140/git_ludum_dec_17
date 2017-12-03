using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondmanage : MonoBehaviour {


    public static GameObject evolution1;
    public  static GameObject evolution2;
    public static GameObject evolution3;



    private bool transformous;
    public static int number;
    //public static int number;

    // Use this for initialization
    void Start()
    {
       // number = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public static void TAMERE()
    {

        number = number +1 ;

        if (number == 1)
        {
            GameObject currentprojectile1 = Instantiate(evolution1);
            currentprojectile1.transform.position = shipcontroller.posi;

        }

        if (number == 2)
        {

            GameObject currentprojectile2 = Instantiate(evolution2);
            currentprojectile2.transform.position = shipcontroller2.posi;

        }

        if (number == 3)
        {

            GameObject currentprojectile3 = Instantiate(evolution3);
            currentprojectile3.transform.position = vaissseau3.posi;


        }
        Debug.Log("chiotte");
    }

    void ChangeVaiss() { 
}
}
