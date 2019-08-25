using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogCtrl : MonoBehaviour
{

    public GameObject frog;
    public GameObject frogbody;

    Animator anim;

    private void Awake()
    {
        anim = frog.GetComponent<Animator>();
    }

    //void RootMotion()
    //{
    //   if (anim.applyRootMotion)
    //    {
    //        anim.applyRootMotion = false;
    //    }
    //}


    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            anim.Play("Crawl");
        }
        if (Input.GetKeyUp("w"))
        {
            anim.Play("Idle");
        }

        if (Input.GetKeyDown("q"))
        {
            anim.Play("Tongue");
        }

        if (Input.GetKeyDown("space"))
        {
            anim.Play("Jump");
        }


    }
    //Works but buggy
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Water")
        {
          anim.Play("Swimming");          
        }
    }

}

