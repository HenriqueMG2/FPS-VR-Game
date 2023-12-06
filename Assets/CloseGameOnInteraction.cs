using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CloseGameOnInteraction : MonoBehaviour
{
    void OnMouseDown()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Fecha no modo de edição do Unity
#else
        Debug.Log("Jogo fechado!");
        Application.Quit(); // Fecha o jogo em um build
#endif
    }
}
