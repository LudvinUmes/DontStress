using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    private CharacterController characterController;
    public float fallSpeed = 9.8f;
    public float raycastDistance = 1f;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Movimiento vertical
        Vector3 moveDirection = new Vector3(0f, -fallSpeed, 0f);

        // Realizar el Raycast hacia abajo
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance))
        {
            // Ajustar la posición del Character Controller si hay una colisión con un objeto sólido debajo
            characterController.Move(new Vector3(0f, hit.point.y - transform.position.y, 0f));
        }

        // Mover el Character Controller
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
