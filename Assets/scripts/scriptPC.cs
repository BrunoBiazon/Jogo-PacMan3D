using UnityEngine;
using UnityEngine.InputSystem;
public class scriptPC : MonoBehaviour
{

    public float moveSpeed = 8f;



    public float mouseSensitivity = 15f;
    
    public AudioClip somColeta;
    public Transform cameraTransform;

    private CharacterController controller;
    

    private float rotationX = 0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        HandleMouseLook();
        Move();
    }

    private void HandleMouseLook()
    {
        if (Mouse.current == null || cameraTransform == null) return;


        Vector2 mouseDelta = Mouse.current.delta.ReadValue();


        float mouseX = mouseDelta.x * mouseSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);


        float mouseY = mouseDelta.y * mouseSensitivity * Time.deltaTime;
        
        rotationX -= mouseY; 
        rotationX = Mathf.Clamp(rotationX, -60f, 60f);

        cameraTransform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
    }

    private void Move()
    {
        if (Keyboard.current == null) return;

        float moveX = 0f;
        float moveZ = 0f;

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) moveZ = 1f;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) moveZ = -1f;
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) moveX = 1f;
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moveX = -1f;


        Vector3 moveDirection = (transform.forward * moveZ + transform.right * moveX).normalized;

        if (moveDirection != Vector3.zero)
        {
            Vector3 velocity = moveDirection * moveSpeed;
            velocity.y = Physics.gravity.y; 
            
            controller.Move(velocity * Time.deltaTime);
        }
        else
        {

            Vector3 velocity = Vector3.zero;
            velocity.y = Physics.gravity.y;
            controller.Move(velocity * Time.deltaTime);
        }
    }

private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pellet")) // 156 pallets no mapa
        {
            if (somColeta != null)
            {
                AudioSource.PlayClipAtPoint(somColeta, other.transform.position);
            }
            if (scriptGameManager.Instancia != null)
            {
                scriptGameManager.Instancia.AdicionarPontos(5); 
            }

            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Ghost"))
        {
            // GameManager.Instancia.GameOver();
        }
    }
}