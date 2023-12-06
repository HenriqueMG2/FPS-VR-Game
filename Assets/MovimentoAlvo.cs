using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoAlvo : MonoBehaviour
{
    public float velocidade = 5.0f; // Velocidade de movimento

    // Update é chamado a cada frame
    void Update()
    {
        // Movimenta o objeto no eixo X
        transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
    }

    // Detecta colisão com a parede
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Parede"))
        {
            // Inverte a direção do movimento
            velocidade *= -1;
        }
    }
}
