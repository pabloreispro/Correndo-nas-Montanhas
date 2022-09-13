using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorPista : MonoBehaviour
{
   private void OnTriggerEnter(Collider other) 
   {
       Pista.pista.GeraPista();
       Pista.pista.poolModulos.Add(this.transform.GetComponentInParent<ModuloPista>());
       
   }
}
