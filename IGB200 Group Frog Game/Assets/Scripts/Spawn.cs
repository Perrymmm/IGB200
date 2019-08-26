using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNGLocationObjSpawn2 : MonoBehaviour
{
    public GameObject Spawnee;
    public int xPos;
    public int zPos;
    public int ObjectCount;

    void Start()
    {
        StartCoroutine(ObjectSpawn());
    }

    IEnumerator ObjectSpawn()
    {
        while (ObjectCount< 10)
        {
          
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 31);
            Instantiate(Spawnee, new Vector3(xPos, 18, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            ObjectCount += 1;




        }

    }
}
