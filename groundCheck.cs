using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    [SerializeField]private GameObject groundCheckPos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            groundCheckPos.transform.position = new Vector3(transform.position.x, -0.2f, transform.position.z);
        }
    }
}
