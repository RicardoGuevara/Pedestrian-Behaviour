using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza : MonoBehaviour {
  
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "modelo2")
        {
            col.transform.position=new Vector3(0,0,0);
        }
    }

}
