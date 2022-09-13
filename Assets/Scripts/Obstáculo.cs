using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstáculo : MonoBehaviour
{
    private GameObject perso;
    public GameObject pedra;
    private float timer=0f;
    public Rigidbody rb;
    public float valor;
    private void OnTriggerEnter(Collider other) 
    {
        
        if(other.CompareTag("Player"))
        {
            other.GetComponent<Player>().Energia -= valor;
            StartCoroutine(Pisca());
        }
       

    }
    // Start is called before the first frame update
    void Start()
    {
        perso = GameObject.Find("corpo");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       timer += Time.deltaTime;

       if(timer >= 0.5f)
       {
           pedra.GetComponent<MeshCollider>().isTrigger = true;
           rb.isKinematic = true;
       }
    }
    
    public IEnumerator Pisca()
    {
        perso.GetComponent<SkinnedMeshRenderer>().enabled = false;
        yield return new WaitForSecondsRealtime(0.2f);
        perso.GetComponent<SkinnedMeshRenderer>().enabled = true;
        yield return new WaitForSecondsRealtime(0.2f);
        perso.GetComponent<SkinnedMeshRenderer>().enabled = false;
        yield return new WaitForSecondsRealtime(0.2f);
        perso.GetComponent<SkinnedMeshRenderer>().enabled = true;
        
    }
}
