using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAndRespawn : MonoBehaviour
{
    public GameObject blockPrefab; // Adicione o prefab do bloco no Inspector
    public Vector3 respawnPosition = new Vector3(0f, 0f, 0f); // Posição para respawn
    public float hideDelay = 0.5f; // Tempo em segundos para esconder o objeto

    void OnCollisionEnter(Collision collision)
    {
        // Verifica se foi atingido por um objeto com a tag "Projectile"
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Desativa o bloco por um período
            gameObject.SetActive(false);

            // Chama a função para reativar o bloco após o atraso
            Invoke("ReativarBloco", hideDelay);
        }
    }

    void ReativarBloco()
    {
        // Reativa o bloco
        gameObject.SetActive(true);

        // Reposiciona o bloco para a posição especificada
        transform.position = respawnPosition;
    }
}




