using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Personagem;

   void Update(){
       float x = Personagem.transform.position.x;
       
       transform.position = new Vector3(x, transform.position.y, transform.position.z);
   }
}
