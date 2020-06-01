using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class RaycastThing : MonoBehaviour
{
    public float rayLenght;
    public LayerMask layermask;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLenght)) 
            {
                if(hit.collider.name == "StartButton")
                {
                    GetComponent<Timer>().PressStart();

                }
                if(hit.collider.name == "FinnishButton")
                {
                    GetComponent<Timer>().Finnish();
                }
            }

        }
    }
}
