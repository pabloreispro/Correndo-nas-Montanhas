using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        
        this.transform.parent.gameObject.SetActive(false);
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
