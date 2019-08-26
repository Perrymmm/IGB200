using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNGLocationObjSpawn : MonoBehaviour
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
          
            xPos = Random.Range(117, 146);
            zPos = Random.Range(-17, 13);
            Instantiate(Spawnee, new Vector3(xPos, 20, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            ObjectCount += 1;




        }

    }
}
