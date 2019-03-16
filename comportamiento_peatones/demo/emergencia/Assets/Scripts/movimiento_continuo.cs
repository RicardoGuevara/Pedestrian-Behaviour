using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_continuo : MonoBehaviour
{
    public float speed;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(0f,0f,speed * Time.deltaTime);    
        
    }

   
    private void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "rotator_node")
        {
            transform.Rotate(0f,0f,col.transform.rotation.z * Time.deltaTime);
        }
    }

}
