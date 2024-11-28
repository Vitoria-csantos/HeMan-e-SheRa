using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFall : MonoBehaviour
{

        public GameObject platform;

        private void OnCollisionEnter(Collision collision)
        {
            gameObject.AddComponent<Rigidbody>();
        }
    }

