using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainTeaserMovement : MonoBehaviour
{
    private Vector3 _lastMousePosition;

    void Update()
    {
        // Vérifie si le clic gauche est enfoncé
        if (Input.GetMouseButtonDown(0))
        {
            _leftClickActivated = true;
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _leftClickActivated = false;
        }

        // Si le clic gauche est maintenu enfoncé, fait tourner le cube
        if (clicGaucheEnfonce)
        {
            Vector3 deltaMousePosition = Input.mousePosition - lastMousePosition;

            // Fait tourner le cube autour de son centre en fonction des mouvements de la souris
            transform.Rotate(Vector3.up, -deltaMousePosition.x, Space.World);
            transform.Rotate(Vector3.right, deltaMousePosition.y, Space.World);

            lastMousePosition = Input.mousePosition;
        }
    }
}
