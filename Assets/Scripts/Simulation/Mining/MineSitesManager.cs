using System.Collections.Generic;
using UnityEngine;

public class MineSitesManager : Singleton<MineSitesManager>
{
    [SerializeField] private List<GameObject> mineSites = new List<GameObject>();

    public Vector3 GetMineSiteSpawn(Vector3 goblinPosition)
    {
        int i = 0;
        int index = -1;
        var value = float.PositiveInfinity;
        foreach (var site in mineSites)
        {
            float distance = Vector3.Distance(site.transform.position, goblinPosition);
            if (distance < value)
            {
                index = i;
                value = distance;
            }

            i++;
        }
        
        return mineSites[index].transform.position;
    }
}
