using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public GameObject projetil;
    public float distanceToSpawn = 2;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 posicao;
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;
            posicao = transform.position;
            posicao += (mousePosition - this.transform.position).normalized * distanceToSpawn;
            Instantiate(projetil, posicao, Quaternion.identity);

        }
    }
}