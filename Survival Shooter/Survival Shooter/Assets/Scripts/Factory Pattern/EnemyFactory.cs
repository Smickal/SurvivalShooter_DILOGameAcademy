using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField]
    public GameObject[] enemyPrefabs;

    public GameObject FactoryMethod(int tag)
    {
        GameObject enemy = Instantiate(enemyPrefabs[tag]);
        return enemy;
    }
}
