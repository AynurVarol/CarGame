using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CarGame.ArabaHareket;

public class GoldSpawner : MonoBehaviour
{

    public Gold goldRes;
    public Vector3 offset = new Vector3(2, 0, 2);

    public void SpawnGold(int count)
    {
        for (int i = 0; i < count; i++)
        {
            var pos = transform.position + (offset * i);

            // 1. pos = (0,0,0)
            //2. pos =  (2,0,2)
            //3.pos = (4,0,4)
            Instantiate(goldRes, pos, Quaternion.identity);
        }
    }

}

