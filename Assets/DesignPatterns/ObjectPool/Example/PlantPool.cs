using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlantPool : MonoBehaviour
{
    public GameObject PlantPrefab;
    public int PoolSize;

    List<GameObject> plantPool;

    // Start is called before the first frame update
    void Start()
    {
        plantPool = new List<GameObject>();
        Spwan(plantPool, PoolSize);
    }

    private void Spwan(List<GameObject> plantPool, int poolSize)
    {
        for (int i = 0; i < poolSize; i++)
        {
            plantPool.Add(Instantiate(PlantPrefab));
            plantPool[i].name = "Plant_" + i;
            plantPool[i].SetActive(false);
        }
    }

    public void Seed(Transform transform)
    {
        bool isPlant = false;
        for (int i = 0; i < PoolSize; i++)
        {
            if (plantPool[i].activeSelf == true)
            {
                continue;
            }
            plantPool[i].transform.position = transform.position;

            plantPool[i].SetActive(true);
            isPlant = true;
            break;
        }
        if (!isPlant)
        {
            Debug.Log("더 이상 식물을 심을 수 없습니다");
        }
    }

}
