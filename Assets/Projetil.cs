using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float velocidade = 0.2f;
    Vector3 directionToMove;
    float timer = 0;
    float initialTimer = 5;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        directionToMove = (mousePosition - this.transform.position).normalized * velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += directionToMove;

        timer += Time.deltaTime;
        if(timer > initialTimer)
        {
            Destroy(this.gameObject);
            timer = 0;
        }



    }
}