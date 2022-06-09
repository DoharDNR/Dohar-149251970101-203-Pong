using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaKokKotak : MonoBehaviour
{
    public Rigidbody2D fisikObj;
    public float kecepatan;

    public KendaliPemain pemain;
    public void Mulai()
    {
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        fisikObj.velocity = new Vector2(x * kecepatan, y * kecepatan);
    }
}
