using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerParallax : MonoBehaviour
{
    private Vector3 pos;
    Vector3 posinicio;
    public float velocidade;

    private void movimenta()
    {
        pos.x += velocidade;
        this.transform.position = pos;
        if(this.transform.position.x >= 30)
        {
            this.transform.position = posinicio;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        posinicio = this.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        Invoke("movimenta", 1f);
        pos = this.transform.position;

        
    }
}
