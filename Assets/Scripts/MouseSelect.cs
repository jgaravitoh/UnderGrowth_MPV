using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSelect : MonoBehaviour
{
    GameObject selectedObject;
    void Update()
    {
        // Check for mouse click
        CheckSelect();
    }

    private void CheckSelect() //Checks if Mouse clicked a GameObject.
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the mouse position into the scene
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits a GameObject
            if (Physics.Raycast(ray, out hit))
            {
                // Get the selected GameObject
                selectedObject = hit.collider.gameObject;

                // Prints the name of the selected GameObject.
                Debug.Log("Selected Object: " + selectedObject.name);
                SendSelected();
            }
        }
    }
    private void SendSelected()
    {
        gameObject.GetComponent<Player>().selectedGameObject = selectedObject; // Sends the selected object to the Player Script
    }
}
