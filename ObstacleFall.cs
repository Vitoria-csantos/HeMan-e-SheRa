using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ObstacleFall : MonoBehaviour
{

    public LayerMask groundLayer;
    public GameObject platform;
    private void OnCollisionEnter(Collision collision)
        {
            gameObject.AddComponent<Rigidbody>();
      

    }
}

