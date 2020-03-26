using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float velocidade = 0.5f;
    GameObject heroi;
    
    // Start is called before the first frame update
    void Start()
    {
        heroi = GameObject.Find("playerMovin");
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Cos(this.transform.eulerAngles.z * Mathf.Deg2Rad);
        float y = Mathf.Sin(this.transform.eulerAngles.z * Mathf.Deg2Rad);
        Vector3 direcao = new Vector3(x,y,0).normalized;
        Vector3 diferenca = (heroi.transform.position - this.transform.position).normalized;
        float visao = Vector3.Dot(direcao, diferenca);

        float distancia = Vector3.Distance(heroi.transform.position, this.transform.position);
        if(distancia < 10)
        {   
            if(distancia > 2)
            {
                 if(visao > 0.8f)
                {
                    this.transform.position += diferenca * (velocidade * Time.deltaTime);
                }
            }
        }
        else
        {
            if(visao > 0.8f)
            {
                this.transform.position += diferenca * ((velocidade * Time.deltaTime) * 2);
            }
        }
    }
}
