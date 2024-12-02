using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Moviment : MonoBehaviour
{ 
        Vector3 moviment;
        //public Vector3 vel = new Vector3(0f,17f,0f);
       // float g =-9.81f;
       // Vector3 move;
    public Vector3 startPosition = new Vector3(0f, 10f, 0f);

        //public LayerMask groundLayer;
      //  public Transform groundCheck;
        // Start is called before the first frame update
        void Start()
        {
            moviment = new Vector3(-588, 76, -50);
            transform.position = moviment;
            moviment.Set(0, 0, 0);
=======
using UnityEngine;
using UnityEngine.UIElements;

public class moviment : MonoBehaviour
{ 
        Vector3 movimento;
        

        // Start is called before the first frame update
        void Start()
        {
            movimento = new Vector3(-17, 24, -44);
            transform.position = movimento;
            movimento.Set(0, 0, 0);
        

>>>>>>> 1af83f9a23fcd80bc0469bb01f561e384e3f2f89
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            {
<<<<<<< HEAD
                moviment.x = 0.5f;
                transform.Translate(moviment);
            }
            if (Input.GetKey(KeyCode.A))
            {
                moviment.x -= 0.5f;
                transform.Translate(moviment);
            

            }

        if (Input.GetKey(KeyCode.Space))
        {
            moviment.y =0.6f;
            transform.Translate(moviment);
        }

        moviment.Set(0, 0, 0);

      //  vel.y += g * Time.deltaTime;
       // move = vel * Time.deltaTime;
      //  Debug.Log(estaNoChao());
        }
  // public bool estaNoChao()
    //{
       // return Physics.CheckSphere(groundCheck.position, 0.5f, groundLayer);
   // }
}


=======
                movimento.x = 0.5f;
                transform.Translate(movimento);
            }
            if (Input.GetKey(KeyCode.A))
            {
                movimento.x -= 0.5f;
                transform.Translate(movimento);
            }
            
            if (Input.GetKey(KeyCode.Space))
            {
                movimento.y = 0.2f;
                transform.Translate(movimento);
                if (movimento.y >= 24f)
            { 
                

            }
             


        }
        movimento.Set(0, 0, 0);
        }
 
}
>>>>>>> 1af83f9a23fcd80bc0469bb01f561e384e3f2f89
