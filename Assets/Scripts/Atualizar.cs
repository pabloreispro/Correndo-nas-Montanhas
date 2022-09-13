using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atualizar : MonoBehaviour
{
    public static Atualizar HUD;
    // Start is called before the first frame update
    public void tutu(float valor)
    {
        Debug.Log(valor);
    }
    void Start()
    {
        HUD = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
