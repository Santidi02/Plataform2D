using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoYMovimiento : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float jumpForce = 5f;

    private Rigidbody2D rbody;
    private bool isGrounded;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Obtener el movimiento horizontal
        float moveInput = Input.GetAxis("Horizontal");
        
        // Establecer la velocidad en el eje X mientras se mantiene la velocidad en el eje Y
        rbody.velocity = new Vector2(moveInput * movementSpeed, rbody.velocity.y);
        
        // Verificar si puede saltar
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rbody.velocity = new Vector2(rbody.velocity.x, jumpForce);
        isGrounded = false; // Cambiar el estado al saltar
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isGrounded = true; // Establece a true cuando colisiona con el suelo
        }
    }

    private void OnCollisionExit2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isGrounded = false; // Establece a false al salir del suelo
        }
    }
}
