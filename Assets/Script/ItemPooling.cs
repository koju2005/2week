using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ItemPooling : MonoBehaviour
{
    private List<ItemSO> _prefabSO;
    private Dictionary<string, GameObject> _prefabData;
    private Dictionary<string, List<GameObject>> _pool;
    public Transform spawnLocation;
    private void Awake()
    {
        _prefabData = new Dictionary<string, GameObject>();
        _pool = new Dictionary<string, List<GameObject>>();
        _prefabSO = new List<ItemSO>();
    }

    public void Init(string path)
    {
        GameObject[] resources = Resources.LoadAll<GameObject>(path);
        ItemSO[] resourcesSO = Resources.LoadAll<ItemSO>("SO");
        foreach(var resource in resourcesSO)
        {
            _prefabSO.Add(resource);
        }
        int i = 0;
        int xOffset = 0;
        int yOffset = 0;

        foreach (var resource in resources)
        {

            Vector3 spawnvcetor = new Vector3(xOffset * 60, yOffset * -30, 0);

            _prefabData.Add(resource.name, resource);

            GameObject newPrefabInstance;
            resource.GetComponent<Item>().itemSO = _prefabSO[i];
            resource.GetComponentInChildren<Image>().sprite=_prefabSO[i].Sprite;
            newPrefabInstance = Instantiate(resource, spawnLocation.position+ spawnvcetor, spawnLocation.rotation);
            newPrefabInstance.transform.SetParent(spawnLocation);
            
            i++;
            xOffset++;
            if(xOffset % 3 == 0)
            {
                yOffset++;
            }
        }

    }
    private void Start()
    {
        Init("Prefabs");
    }
}
