using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
   int playerHealth = 3; 
   public float playerSpeed = 5.5f;
   string text = "Hello world";
   bool isGrounded = false;
   public SpriteRenderer sRender ;
   float horizontal;
   Rigidbody2D rBody; 
   public float jumpForce = 5.7f;


//int = numero entero
//float = nmero decimal
//String = texto
//bool = cierto o falso
//public + variable = te deja ver la variale en el inspector sin necesidad de modificar el script

    // Start is called before the first frame update
    void Start()
    {
        sRender = GetComponent<SpriteRenderer> ();
        rBody = GetComponent<Rigidbody2D>();
        playerHealth = 10;
        Debug. Log(text);
        
    }

    // Update is called once per frame
    void Update()
    {
      horizontal = Input . GetAxis("Horizontal");

      transform. position += new Vector3 (horizontal, 0, 0) * playerSpeed * Time . deltaTime ;  

      if (horizontal < 0 )
      {
        sRender.flipX = true;
      }

      else if (horizontal > 0 )
      {
        sRender.flipX = false;
      }

      if(Input.GetButtonDown("Jump"))
      {
        rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
      }
    }
}
