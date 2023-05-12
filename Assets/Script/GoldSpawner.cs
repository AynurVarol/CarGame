using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CarGame.ArabaHareket;

public class GoldSpawner : MonoBehaviour
{

    public GameObject goldRes;
    public Vector3 offset = new Vector3(2, 0, 2);
    public int countX, countZ;


    private void Start()
    {
        SpawnGold();
    }


    public void SpawnGold()
    {
        for (int i = 0; i < countX; i++)
        {
            var x = transform.position.x + (offset.x * i);
           

            for (int k = 0; k < countZ; k++)
            {
                var z = transform.position.z + (offset.z * k);
                var pos = new Vector3(x, transform.position.y, z);
                Instantiate(goldRes, pos, Quaternion.identity);
                Debug.Log("x = " + x + " z = " + z);
            }
        }
    }

}

