using UnityEngine;

public class Gawang : MonoBehaviour
{
    public PaddleController pemain1, pemain2;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.name == "Gawang1")
        {
            //pemain1.skorPemain1 += 1;
        }
        else
        {
            //pemain2.skorPemain2 += 1;
        }
    }
}
