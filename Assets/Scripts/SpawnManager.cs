﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

        void SpawnRandomAnimal()
        {
            int animalIndex = Random.Range(0, animalPrefab.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
        }
    }

