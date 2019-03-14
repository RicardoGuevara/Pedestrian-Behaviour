using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dist : MonoBehaviour {
     GameObject Obj1;
     GameObject Obj2;
    public float Distance;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void distance() {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Carritos");
        string nombre = gameObject.name;
        for (int i = 0; i < gos.Length; i++)
        {
            if (gos[i].Equals(GameObject.Find(nombre))) {
              
                Obj1 = GameObject.Find(nombre);
            }
            Debug.Log("Player Number " + i + " is named " + gos[i].name);
            
        }
   

        Obj2 = GameObject.FindWithTag("Player");
        Distance = Vector3.Distance(Obj1.transform.position, Obj2.transform.position);
    }
}
