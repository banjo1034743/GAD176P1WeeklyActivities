using System.Collections.Generic;
using GAD176.P2.ClassActivities.Week10.Holograms;
using UnityEngine;

public class HologramPoolManager : MonoBehaviour
{
    public static HologramPoolManager Instance;

    public GameObject hologramPrefab;
    public int poolSize = 10;

    [SerializeField] private List<GameObject> _hologramPool;

    private void Awake()
    {
        Instance = this;
        InitializeHologramPool();
    }

    private void InitializeHologramPool()
    {
        _hologramPool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject newHologram = Instantiate(hologramPrefab);
            newHologram.SetActive(false);
            _hologramPool.Add(newHologram);
        }
    }

    public Hologram GetPooledHologram()
    {
        foreach (GameObject hologram in _hologramPool)
        {
            if (!hologram.activeInHierarchy)
            {
                return hologram.GetComponent<Hologram>();
            }
        }

        GameObject newHologram = Instantiate(hologramPrefab);
        newHologram.SetActive(false);
        _hologramPool.Add(newHologram);

        return newHologram.GetComponent<Hologram>();
    }
}
