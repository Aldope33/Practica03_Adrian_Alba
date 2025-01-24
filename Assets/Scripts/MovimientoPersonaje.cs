using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoPersonaje : MonoBehaviour

{
    [SerializeField] private float vel = 5;
    private float moveInput;

    private void Start()
    {
        // Posición central de la cámara
        Vector3 centerPosition = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.nearClipPlane));

        // Establece la posición inicial del persnaje en la parte centrada de la izquierda de la pantalla
        transform.position = new Vector3(centerPosition.x, transform.position.y, transform.position.z);    
    }

    private void OnMovimiento(InputValue value)
    {
        moveInput = value.Get<Vector2>().y;
        moveInput = value.Get<Vector2>().x;   
    }


}