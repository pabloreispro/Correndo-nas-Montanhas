using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    
    Image d;
    public static UIcontroller HUD;

    public void atualizaEnergia(float valor)
    {
        
        d.fillAmount = valor;
    }
    // Start is called before the first frame update
    void Start()
    {
        d = GetComponent<Image>();
        HUD = this;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
