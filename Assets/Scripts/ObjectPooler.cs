using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public GameObject pooledObject;
    public int pooledAmount;
    List<GameObject> pooledObjects;


    // Use this for initialization
    void Start()
    {
        pooledObjects = new List<GameObject>();

        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject() {
        for (int i = 0; i<pooledObjects.Count;i++) {
            if (!pooledObjects[i].activeInHierarchy) {
                return pooledObjects[i];
            }
        }
        //Si no hay ninguno desactivado no puedo usar ninguno, entonces, creo uno nuevoy así puedo usar el nuevo
        GameObject obj = (GameObject)Instantiate(pooledObject);
        obj.SetActive(false);
        pooledObjects.Add(obj);
        return obj;

    }
}
