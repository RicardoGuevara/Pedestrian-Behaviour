using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_continuo : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    
    void Update()
    {
        transform.Translate(0f,0f,speed * Time.deltaTime);    
    }
}
