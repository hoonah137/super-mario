using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
   int playerHealth = 3; 
   public float playerSpeed = 5.5f;
   string text = "Hello world";
   bool isGrounded = false;

//int = numero entero
//float = nmero decimal
// String = texto
//bool = cierto o falso
// public + variable = te deja ver la variale en el inspector sin necesidad de modificar el script

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 10;
        Debug. Log(text);
        
    }

    // Update is called once per frame
    void Update()
    {
      transform. position += new Vector3 (Input . GetAxis("Horizontal"), 0, 0) * playerSpeed * Time . deltaTime ;  
    }
}
