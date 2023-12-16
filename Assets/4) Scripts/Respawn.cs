using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public CarController carcontroller;


    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enviroment" )
        {
          
            carcontroller.ResetToTrack();

        }

    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
