using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energia : MonoBehaviour
{
    public float valor;
    
    

    private void OnTriggerEnter(Collider other) 
    {
        
        other.GetComponent<Player>().Energia += valor;
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
