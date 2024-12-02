using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public Transform RestartPoint;
    public GameObject jogador;
    public void OnCollisionEnter(Collision collision)
    {
        jogador.transform.position = RestartPoint.position;
    }
}

    
