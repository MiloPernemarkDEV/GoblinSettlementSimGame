using System;
using UnityEngine;

public class ResourcePresenter : MonoBehaviour
{
    public void Change(ResourceType resourceType, ResourceAction resourceAction, int amount)
    {
        SimulationRuntime.Instance.Model.Resourceses.Change(resourceType, resourceAction, amount);
    }
}
