using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer21 : MonoBehaviour
{

    // Use this for initialization

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.z >= -23)
        {
            Rotador();
        }
      //  if (this.transform.position.z >= -16.27) {
        //    Destruction();
        //}

    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }
    void Rotador() {
        this.transform.Rotate(0, 23, 0);
    }
}
