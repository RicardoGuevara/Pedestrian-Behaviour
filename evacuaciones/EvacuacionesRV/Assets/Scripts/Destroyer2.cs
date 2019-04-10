using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer2 : MonoBehaviour
{

    // Use this for initialization

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.z >= -16.27)
        {
            //  this.transform.Rotate(0,180,0);
            Destruction();
        }

    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Destroyer1" || coll.gameObject.name == "Destroyer2" || coll.gameObject.name == "Destroyer3" || coll.gameObject.name == "LastRoom")
        {
            Destruction();
        }
    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }
}