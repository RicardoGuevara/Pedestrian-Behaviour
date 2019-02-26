using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_interval_generation : MonoBehaviour {

    public GameObject auto1,    //base_car
                      auto2,    //base_cam
                      auto3,    //base_bus
                      auto4,    //base_car
                      auto5,    //base_cam
                      auto6,    //base_bus
                      auto7;

    public Transform origen;    // base pos 

    // Use this for initialization
    
    void Update()
    {
        StartCoroutine(delay_and_create(gen_random_delay()));
    }

    private bool isCoroutineExecuting = false;

    IEnumerator delay_and_create(float time)
    {
        if (isCoroutineExecuting) yield break;

        isCoroutineExecuting = true;

        yield return new WaitForSeconds(time);

        gen_trafic();
        //Instantiate(auto1, origen.position, origen.rotation);

        isCoroutineExecuting = false;
    }

    float gen_random_delay()
    {
        return Random.Range(0.5f, 5f);
    }

    void gen_trafic()
    {
        int model = Random.Range(1, 8);

        switch (model)
        {
            case 1:
                Instantiate(auto1, origen.position, origen.rotation);
                break;
            case 2:
                Instantiate(auto2, origen.position, origen.rotation);
                break;
            case 3:
                Instantiate(auto3, origen.position, origen.rotation);
                break;
            case 4:
                Instantiate(auto4, origen.position, origen.rotation);
                break;
            case 5:
                Instantiate(auto5, origen.position, origen.rotation);
                break;
            case 6:
                Instantiate(auto6, origen.position, origen.rotation);
                break;
            case 7:
                Instantiate(auto7, origen.position, origen.rotation);
                break;
        }
    }
}
