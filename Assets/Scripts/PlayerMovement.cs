using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    public float velocidad = 5f;
    // This code sucks ass XD, we need to better it.
    void Update()
    {
        // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular la dirección del movimiento
        Vector3 direccion = new Vector3(movimientoHorizontal, 0f, movimientoVertical).normalized;

        // Mover el personaje
        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
    }
}
