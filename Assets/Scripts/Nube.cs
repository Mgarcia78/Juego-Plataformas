using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nube : MonoBehaviour {
    public float speed = 1.0f;

    // Initialization
    void Start()
    {
        //Hace que las nubes no se muevan todas a la misma velocidad
        speed += Random.Range(-0.5f, 0.5f);

        //Hace que cambien de escala aleatoriamente entre 0.8 y 1.2
        transform.localScale *= Random.Range(0.8f, 1.2f);

        //float alphaToRemove = Random.Range(0.0f, 0.75f);

        //Dentro del transform padre pasa por todos los transform hijos y cambia su color aleatoriamente
        
        /*
        foreach (Transform child in transform)
        {
            Color pepe = child.GetComponent<SpriteRenderer>().color;
            pepe.a -= alphaToRemove;
            Child.GetComponent<SpriteRenderer>().color = pepe;

        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        //Hace que las nubes se muevan hacia la derecha
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
