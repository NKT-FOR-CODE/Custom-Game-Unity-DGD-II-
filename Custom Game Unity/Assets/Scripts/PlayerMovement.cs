using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public new Transform camera;
    public float speed = 6;
    public Rigidbody rb;


    private void Start()
    {

    }
    void Update()
    {
        Transform camTransform = Camera.main.transform;
        Vector3 camPosition = new Vector3(camTransform.position.x, transform.position.y, camTransform.position.z);
        Vector3 direction = (transform.position - camPosition).normalized;
        Vector3 forwardMovement = direction * Input.GetAxis("Vertical");
        Vector3 horizontalMovement = camTransform.right * Input.GetAxis("Horizontal");
        Vector3 movement = Vector3.ClampMagnitude(forwardMovement + horizontalMovement, 1);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    void FixedUpdate()
    {
        rb.velocity += Physics.gravity * Time.fixedDeltaTime; // In PhysX, Acceleration ignores mass
        float rigidbodyDrag = Mathf.Clamp01(1.0f - (rb.drag * Time.fixedDeltaTime));
        rb.velocity *= rigidbodyDrag;
        transform.position += rb.velocity * Time.fixedDeltaTime;
    }
}
