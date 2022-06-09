using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KendaliPemain : MonoBehaviour
{
    public float kecepatan;
    public Rigidbody2D fisikObj;

    public int skorPemain1;
    public int skorPemain2;
    void Update()
    {
        if (tag == "Player")
        {
            if (Input.GetKey(KeyCode.W))
            {
                fisikObj.velocity = new Vector2(0f, kecepatan);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                fisikObj.velocity = new Vector2(0f, -kecepatan);
            }
        }

        if (tag == "Player2")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                fisikObj.velocity = new Vector2(0f, kecepatan);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                fisikObj.velocity = new Vector2(0f, -kecepatan);
            }
        }
    }
}
