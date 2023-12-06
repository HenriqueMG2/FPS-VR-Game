using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRespawn : MonoBehaviour
{
    public float speed = 1f; // Ajuste a velocidade conforme necessário
    public float respawnY = 0f; // Posição Y para respawn
    public GameObject blockPrefab; // Prefab do bloco para respawn
    private GameObject currentBlock;

    void Start()
    {
        // Inicializa o bloco inicial
        SpawnBlock();
    }

    void Update()
    {
        // Movimento para cima e para baixo ao longo do eixo Y
        currentBlock.transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Se atingir a distância máxima, inverte a direção e reseta a posição Y
        if (currentBlock.transform.position.y > respawnY + 0.5f || currentBlock.transform.position.y < respawnY - 0.5f)
        {
            speed = -speed;
            RespawnBlock();
        }
    }

    void RespawnBlock()
    {
        // Destrói o bloco atual
        Destroy(currentBlock);

        // Cria um novo bloco na posição Y especificada
        SpawnBlock();
    }

    void SpawnBlock()
    {
        // Cria um novo bloco e atribui à variável currentBlock
        currentBlock = Instantiate(blockPrefab, new Vector3(0f, respawnY, 0f), Quaternion.identity);
    }
}


