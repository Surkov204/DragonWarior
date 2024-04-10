using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            anim.SetTrigger("explode");
        }
    }
}
