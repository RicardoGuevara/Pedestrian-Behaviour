using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Colision : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
    {
        this.transform.position = new Vector3(-381, 0, 0);
    }
}
