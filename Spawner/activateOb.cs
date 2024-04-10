using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateOb : MonoBehaviour
{
    public GameObject obj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            obj.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
