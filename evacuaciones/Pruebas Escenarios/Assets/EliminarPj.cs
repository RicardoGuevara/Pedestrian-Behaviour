using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarPj : MonoBehaviour {
   
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {


        if (this.transform.position.z >= 0.5)
        {
            Destruction();
        }

    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }
}
