using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarPjGiran : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {


        if (this.transform.position.x >= -6)
        {
            anim.SetFloat("Girar", 1.0f);
          

        }
        if (this.transform.position.z >= 1) {
            Destruction();
        }

    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }
    void Rotar() {
        this.transform.Rotate(0, 45, 0);
    }
}