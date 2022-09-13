using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 playerposition;
    public float vel;
    public AudioSource audio;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource musica;
    public bool inicio = false;
    public bool IsGround;
    public Animator maquina;
    public float decrescimo = 0.005f;
    public float t = 5f;

    public GameObject relogio,safe,a,b;


    

    
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("energia"))
        {
            //audio.PlayOneShot(um);
            audio.Play();
        }
        if(other.CompareTag("pedra"))
        {
            audio2.Play();
            
            //audio.PlayOneShot(dois);
        }   
        if(other.CompareTag("tempo"))
        {
             
            decrescimo = 0;
            musica.Pause();
            audio3.Play();
            relogio.SetActive(true);
            
        } 
        
    }

    private void OnCollisionEnter(Collision other) 
    {
       if(other.gameObject.tag == "ground")
       {
           IsGround = true; 
           maquina.SetTrigger("ground");    
       } 
    }
    private float energia = 0.5f;

    public float Energia
    {
        get
        {
            return energia;
        }
        set
        {
            energia = value;

            if(energia < 0.01f)
            {
                SceneManager.LoadScene("Gameover");
            }

            UIcontroller.HUD.atualizaEnergia(energia);
        }
    }

    
    public void Movimento()
    {
        
        if(inicio == true)
        {
            
            Vector3 velo = new Vector3(2f, 0, 0)*Time.deltaTime;
            rb.MovePosition(transform.position+velo);
            
            

            if(Input.touchCount > 0)
            {
            
                Touch toque = Input.GetTouch(0);
                
                if(toque.phase == TouchPhase.Moved )
                {
                    if(toque.deltaPosition.y > 20 && gameObject.transform.position.y < 5.5f && gameObject.transform.position.y > 1)
                    {
                        IsGround = false;
                        maquina.SetTrigger("pular"); 
                        rb.AddForce(Vector3.up*vel);                      
                    }

                    
                }
            
            }
            
        }
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
        musica.Play();
        rb = GetComponent<Rigidbody>();
        StartCoroutine("desconto"); 
        
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movimento();
        if(Input.touchCount == 5)
        {
            if(rb.isKinematic == false)
            {
                rb.isKinematic = true;
            }
            else
            {
                rb.isKinematic = false;
            }
            
        }
        
    }

    IEnumerator desconto()
    {
        
        

        while(energia > 0)
        {
            if(Time.realtimeSinceStartup > 180f)
            {
                print("ENTREI");
                if(b.active == false && a.active == true)
                    {
                        
                        b.SetActive(true);
                        a.SetActive(false);
                        yield return new WaitForSecondsRealtime(180f);
                    }
                    else
                    {
                        
                        b.SetActive(false);
                        a.SetActive(true);
                        yield return new WaitForSecondsRealtime(180f);
                    }
            } 
            if(energia >0.75)
            {
                Energia += 0.02f;
                safe.SetActive(true);
                yield return new WaitForSecondsRealtime(5.0f);
                Energia-= 0.02f;
                safe.SetActive(false);
            }
            if(decrescimo <= 0)
            {
            yield return new WaitForSecondsRealtime(5f);
            musica.Play();
            audio3.Pause();
            decrescimo = 0.005f;
            relogio.SetActive(false);

            }
        yield return new WaitForSecondsRealtime(2.0f);
        Energia -= decrescimo;
        }
        
    }
        
    
      
    
}
