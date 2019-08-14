using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogCtrl : MonoBehaviour
{

    public GameObject frog;
    public GameObject frogbody;

    Animator anim;

    // Start is called before the first frame update
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


    // Update is called once per frame
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
    }





}

