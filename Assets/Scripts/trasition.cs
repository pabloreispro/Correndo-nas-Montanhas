using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trasition : MonoBehaviour
{


public GameObject b,a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        StartCoroutine("troca");
        
       
    }

    public IEnumerator troca()
    {
        if(Input.touchCount == 4)
       {
           
           if(b.active == false && a.active == true)
            {
                yield return new WaitForSecondsRealtime(0.5f);
                b.SetActive(true);
                a.SetActive(false);
            }
            else
            {
                yield return new WaitForSecondsRealtime(0.5f);
                b.SetActive(false);
                a.SetActive(true);
            }
       } 
    }
}
