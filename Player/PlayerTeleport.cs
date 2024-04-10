using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public GameObject endteleport;
    Transform endteleportPostion;
    private void Start()
    {
        endteleportPostion = endteleport.transform;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "teleport")
        {
            transform.position = endteleportPostion.transform.position;
            Camera.main.GetComponent<camera>().MoveToNewRoom(endteleportPostion.parent);
        }
    }
}
