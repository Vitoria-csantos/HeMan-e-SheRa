using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
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
        

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            {
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
