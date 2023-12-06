using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
    public GameObject blockPrefab; // Adicione o prefab do bloco no Inspector
    public float respawnX = 0f;
    void OnCollisionEnter(Collision collision)
    {
        // Verifica se foi atingido por um objeto com a tag "Projectile"
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Destroi o bloco atual
            Destroy(gameObject);

            // Cria um novo bloco (opcional)
            Instantiate(blockPrefab, new Vector3(respawnX, 0f, 0f), Quaternion.identity);
        }
    }
}
