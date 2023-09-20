using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ItemPooling : MonoBehaviour
{
    private Dictionary<string, GameObject> _prefabData;
    private Dictionary<string, List<GameObject>> _pool;
    public Transform spawnLocation;
    private void Awake()
    {
        _prefabData = new Dictionary<string, GameObject>();
        _pool = new Dictionary<string, List<GameObject>>();
    }

    public void Init(string path)
    {
        GameObject[] resources = Resources.LoadAll<GameObject>(path);
        foreach (var resource in resources)
        {

          
            _prefabData.Add(resource.name, resource);

            GameObject newPrefabInstance;
            newPrefabInstance= Instantiate(resource, spawnLocation.position, spawnLocation.rotation);
            newPrefabInstance.transform.SetParent(spawnLocation);

            Debug.Log(resource.name);
        }
    }
    private void Start()
    {
        Init("Prefabs");
    }
}
