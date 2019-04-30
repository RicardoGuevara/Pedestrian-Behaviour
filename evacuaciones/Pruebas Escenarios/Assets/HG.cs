using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HG : MonoBehaviour {
    public Animator anim;
    // Use this for initialization
    void Start()
    {
        Invoke("animaciones", 5);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void animaciones()
    {
        anim.SetFloat("Giro", 1.0f);
    }
}
