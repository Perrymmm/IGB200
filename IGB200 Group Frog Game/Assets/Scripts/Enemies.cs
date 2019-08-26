using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public Healthbar hpbar;
    public GameObject HpFly;
    public ScoreScript score;

    public Transform TeleportLocation;
    public GameObject ObjectToTele;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyFrog")
        {
            if (hpbar)
            {
                hpbar.TakeDamage(10);
            }
        }

        if (collision.gameObject.tag == "Fly")
        {
            if (hpbar)
                hpbar.hp += 10; //Doesnt work
            score.ScoreVal += 10;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Friendly")
        {
            score.ScoreVal += 50; // Doesn't work

        }
    }
}
