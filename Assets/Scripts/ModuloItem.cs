using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuloItem : MonoBehaviour
{
    public GameObject[] listaColetaveis;
    // Start is called before the first frame update
    void Start()
    {
        int random = Random.Range(0,listaColetaveis.Length - 1);
        Instantiate(listaColetaveis[random], this.transform);
    }

    
}
