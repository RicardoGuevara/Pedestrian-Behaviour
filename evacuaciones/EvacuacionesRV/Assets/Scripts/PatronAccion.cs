using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatronAccion : MonoBehaviour
{
    // Public variables
    public GameObject ObjetoActivador;
    public float TiempoAntesDeAccion;
    public float TiempoDespuesDeAccion;

    // Private variables
    private float timeToStart;
    private float timeToEnd;
    private bool workDone;

    // Start is called before the first frame update
    void Start()
    {
        this.enabled = false;
        timeToStart = 0;
        timeToEnd = 0;
        workDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!workDone)
        {
             Destroy(ObjetoActivador);
            workDone = true;
        }

    }
}
