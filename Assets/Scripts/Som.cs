using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Som : MonoBehaviour
{
    public AudioMixer mix;
    public Slider VolEfeito, Volmusica;
    private float volumeefeito, volumemusica;

    public float VolumeEfeito
    {
        get
        {
            return volumeefeito;
        }
        set
        {
            volumeefeito = value;
            mix.SetFloat("EfeitoSom", volumeefeito);
        }
    }
         public float VolumeMusica
    {
        get
        {
            return volumemusica;
        }
        set
        {
            volumemusica = value;
            mix.SetFloat("EfeitoMusica", volumemusica);
        }

    }
    void Start()
    {
        DontDestroyOnLoad(this);
        
        mix.GetFloat ("EfeitoMusica", out volumemusica);
        Volmusica.value = VolumeMusica;

        mix.GetFloat("EfeitoSom", out volumeefeito);
        VolEfeito.value = VolumeEfeito;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
