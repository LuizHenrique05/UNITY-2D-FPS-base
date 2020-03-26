using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float velocidade = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey( KeyCode.A))
        {
            transform.Translate(-1 * (velocidade * Time.deltaTime), 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1 * (velocidade * Time.deltaTime), 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 1 * (velocidade * Time.deltaTime), 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -1 * (velocidade * Time.deltaTime), 0);
        }
    }
}
