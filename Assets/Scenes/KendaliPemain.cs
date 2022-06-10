using UnityEngine;
using UnityEngine.UI;

public class KendaliPemain : MonoBehaviour
{
    public int kecepatan = 20;
    public Rigidbody2D fisikObj;

    public float skorPemain1;
    public Text skorTextPemain1;
    public float skorPemain2;
    public Text skorTextPemain2;

    void Update()
    {
        if (tag == "Player")
        {
            skorTextPemain1.text = skorPemain1.ToString();
            if (Input.GetKey(KeyCode.W))
            {
                fisikObj.velocity = new Vector2(0f, kecepatan);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                fisikObj.velocity = new Vector2(0f, -kecepatan);
            }
            else
            {
                fisikObj.velocity = new Vector2(0f, 0f);
            }
        }

        if (tag == "Player2")
        {
            skorTextPemain2.text = skorPemain2.ToString();
            if (Input.GetKey(KeyCode.UpArrow))
            {
                fisikObj.velocity = new Vector2(0f, kecepatan);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                fisikObj.velocity = new Vector2(0f, -kecepatan);
            }
            else
            {
                fisikObj.velocity = new Vector2(0f, 0f);
            }
        }
    }
}
