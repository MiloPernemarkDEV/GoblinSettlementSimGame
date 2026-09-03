using System;
using UnityEngine;

public class ResourcePresenter : MonoBehaviour
{
    public void UseResource(ResourceType resourceType, int amount)
    {
        SimulationRuntime.Instance.Model.Resourceses.Use(resourceType, amount);
    }

    public void AddResource(ResourceType resourceType, int amount)
    {
        SimulationRuntime.Instance.Model.Resourceses.Add(resourceType, amount);
    }
}
