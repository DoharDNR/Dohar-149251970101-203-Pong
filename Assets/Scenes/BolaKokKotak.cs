using UnityEngine;

public class BolaKokKotak : MonoBehaviour
{
    public Rigidbody2D fisikObj;
    public float kecepatan;

    public void Mulai()
    {
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        fisikObj.velocity = new Vector2(x * kecepatan, y * kecepatan);

        Debug.Log("Created By DoharSiregar - 149251970101-203");
        Debug.Log("Kecepatan kedua Paddle Sekarang Sebesar " + kecepatan);
    }
}
