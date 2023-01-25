using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
   public bool isGrounded;
   private PlayerControler controller;

    private void Awake() {
      controller = GetComponentInParent<PlayerControler>();
   }

    private void OnTriggerEnter2D(Collider2D other) 
   {
      isGrounded = true;
      controller.anim.SetBool("IsJumping",false);
   }

   private void OnTriggerStay2D(Collider2D other) 
   {
      isGrounded = true;
      controller.anim.SetBool("IsJumping",false);
   }

    private void OnTriggerExit2D(Collider2D other) 
   {
      isGrounded = false;
   }
}
 