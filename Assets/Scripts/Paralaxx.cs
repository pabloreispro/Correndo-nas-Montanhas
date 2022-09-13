using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralaxx : MonoBehaviour
{
    private float length;
    private float StartPos;

    public GameObject cam;

    public float parallax;
    // Start is called before the first frame update
    void Start()
    {
      StartPos = transform.position.x;
      length = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float rep = cam.transform.position.x * (1 - parallax);
        float dist = cam.transform.position.x * parallax;

        transform.position = new Vector3(StartPos + dist, transform.position.y, transform.position.z);

        if(rep > StartPos + length)
        {
            StartPos+=length;
        }
        else if( rep < StartPos - length)
        {
            StartPos-=length;
        }
    }
}
