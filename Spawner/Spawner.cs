using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnerCooldown;
    [SerializeField] private Transform spawPoint;
    [SerializeField] private GameObject[] spawnEnermy;
    
    // [SerializeField] private AudioClip arrowSound;
    private float cooldownTimer;

    private void spawn()
    {
        cooldownTimer = 0;
        spawnEnermy[FindEnermy()].transform.position = spawPoint.position;
        spawnEnermy[FindEnermy()].gameObject.SetActive(true);

    }

    private int FindEnermy()
    {
        for (int i = 0; i < spawnEnermy.Length; i++)
        {
            if (!spawnEnermy[i].activeInHierarchy)
                return i;
        }
        return 0;
      
    }
    private void Update()
    {
        cooldownTimer += Time.deltaTime;
        if (cooldownTimer >= spawnerCooldown)
            spawn();

        

    }
}





