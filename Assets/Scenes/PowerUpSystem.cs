using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSystem : MonoBehaviour
{
    public Transform spawnObjekTransform;
    public GameObject powerUpObj;
    public float timeCooldown;
    public float durasiWaktu;

    void Start()
    {
        durasiWaktu = timeCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        durasiWaktu -= Time.deltaTime; 
        if (durasiWaktu < 0)
        {
            int y = Random.Range(5, -5);

            spawnObjekTransform.position = new Vector2(10, y);

            durasiWaktu = timeCooldown;

            Instantiate(powerUpObj, spawnObjekTransform);
        }
    }
}
