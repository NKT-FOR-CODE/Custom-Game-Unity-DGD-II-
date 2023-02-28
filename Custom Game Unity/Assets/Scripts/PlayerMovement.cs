using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform camera;
    public float speed = 2;


    private void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space");
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("A");
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            
        }
    }
}
