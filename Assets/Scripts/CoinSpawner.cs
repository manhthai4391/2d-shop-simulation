using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField]
    Transform spawnLocation;

    [SerializeField]
    GameObject prefab;

    [SerializeField]
    float coolDowntime = 3f;

    WaitForSeconds spawnDelay;

    GameObject coinInstance;

    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = new WaitForSeconds(coolDowntime);
        coinInstance = Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
        StartCoroutine(Reactivate());
    }

    IEnumerator Reactivate()
    {
        while (true)
        {
            yield return spawnDelay;
            if (!coinInstance.activeInHierarchy)
                coinInstance.SetActive(true);
        }
    }
}
