using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D fisikObj;

    public void Mulai()
    {
        fisikObj.velocity = speed;

        Debug.Log("Created By DoharSiregar - 149251970101-203");
        Debug.Log("Kecepatan kedua Paddle Sekarang Sebesar ");
    }
}
