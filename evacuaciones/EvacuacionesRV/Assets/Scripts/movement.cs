using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody rb;
    private float timeTo=0f;
    private float total = 0, sw = 0;
    public float WaitTime = 0f;
    public float moveSpeed = 1f;
    public float turnSpeed = 1f;
    int range = Random.Range(0, 4);
    bool s = false;
    //int range = Random.Range(0, 4);

    public void Start()
    {
     

    }

    // Update is called once per frame
    public void Update()
    {
        
        timeTo += Time.deltaTime;
        if (timeTo > 0.5f && timeTo<1f)
        {
           
            ChangeDirection(range);
            timeTo += Time.deltaTime;
        }
        if (timeTo >= 1.5)
        {
            timeTo = 0;
            range = Random.Range(0, 4);
        }
        

  

    }



    private void ChangeDirection(int range)
    {
        float sec = 3f;
        if (range == 0)
        {

            while (sec >= 0f)
            {
                transform.Translate(Vector3.forward * moveSpeed * 0.01f);
                sec = sec - Time.deltaTime;
            }


        }
        if (range == 1)
        {

            while (sec >= 0f)
            {
                transform.Translate(-Vector3.forward * moveSpeed * 0.01f);
                sec = sec - Time.deltaTime;

            }
        }
        if (range == 2)
        {

            while (sec >= 0f)
            {
                transform.Rotate(Vector3.up, -turnSpeed * 0.01f);
                sec = sec - Time.deltaTime;

            }
        }

        if (range == 3)
        {

            while (sec >= 0f)
            {
                transform.Rotate(Vector3.up, turnSpeed * 0.01f);
                sec = sec - Time.deltaTime;


            }

        }
    }
}