using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pista : MonoBehaviour
{
    static public Pista pista; 
    ModuloPista copia;
    public ModuloPista[] listaModulos;  
    public List<ModuloPista> poolModulos; 
    public int tamanhoPista;  
    public float velocidade;
    private GameObject[] listaColeta;
    private Vector3 posPista;
    Vector3 posicao;                                                                                                                                                                                                   

    private void movimentaPista()
    {
        posPista.x -= velocidade;

        this.transform.position = posPista;
    }

    public void GeraPista()
    {
        if(poolModulos.Count < 4)
        {
            int random = Random.Range(1, listaModulos.Length);
            
            posicao  = copia.conector.position;
            copia = Instantiate(listaModulos[random], this.transform);
            
            copia.transform.position = posicao;          
        
        }
        else
        {
            int random = Random.Range(0, poolModulos.Count);
            posicao  = copia.conector.position;

            copia = poolModulos[random];
            copia.transform.position = posicao;

            int filhos = poolModulos[2].Coletaveis.transform.childCount;
            for (int i = 0; i < filhos; i++)
            {
                poolModulos[2].Coletaveis.transform.GetChild(i).gameObject.SetActive(true);
            }
            
            


            poolModulos.RemoveAt(random);
        }
    } 
  
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("movimentaPista", 2f, 0.05f);
        posPista = this.transform.position;

        pista = this;
        copia = Instantiate(listaModulos[0], this.transform);

        for (int i = 1; i < tamanhoPista; i++)
        {
            GeraPista();
        }
            
    }
   
    
   



}
