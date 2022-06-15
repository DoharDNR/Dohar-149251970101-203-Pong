using UnityEngine;
using UnityEngine.UI;

public class PaddleController : MonoBehaviour
{
    public int speed = 20;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        } else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        transform.Translate(movement * Time.deltaTime);
    }
}
