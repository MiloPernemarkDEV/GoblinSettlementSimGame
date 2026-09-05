using System.Collections.Generic;
using UnityEngine;

public class MineSitesManager : Singleton<MineSitesManager>
{
    [SerializeField] private Dictionary<int, GameObject> mineSites = new Dictionary<int, GameObject>();

    public Vector3 GetMineSiteSpawn()
    {
        var spawnIndex = Random.Range(0, mineSites.Count);
        var i = 0;
        foreach (var site in mineSites.Values)
        {
            if (i++ == spawnIndex)
                return site.transform.position;
        }

        return Vector3.zero;
    }
}
