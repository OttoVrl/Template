using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    [Serializable]
    public struct Pool
    {
        public Queue<GameObject> pooledLevels;
        public GameObject objectPrefab;
        public int poolSize;
    }

    [SerializeField] private Pool[] pools = null;

    private void Awake()
    {
        for (int j = 0; j < pools.Length; j++)
        {
            pools[j].pooledLevels = new Queue<GameObject>();

            for (int i = 0; i <  pools[j].poolSize; i++)
            {
                GameObject obj = Instantiate( pools[j].objectPrefab);
                obj.SetActive(false);
            
                pools[j].pooledLevels.Enqueue(obj);
            }
        }
    }

    public GameObject GetPooledObject(int objectType)
    {
        if (objectType >= pools.Length)
        {
            return null;
        }
        
        GameObject obj =  pools[objectType].pooledLevels.Dequeue();
        for (int i = 0; i < pools.Length; i++)
        {
            pools[i].objectPrefab.SetActive(false);
        }
        
        obj.SetActive(true);
        
        pools[objectType].pooledLevels.Enqueue(obj);

        return obj;
    }
}