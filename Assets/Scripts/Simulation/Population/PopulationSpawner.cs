using System;
using UnityEngine;

public class PopulationSpawner : MonoBehaviour
{
    [SerializeField] private GameObject goblinPrefab;
    
    public void OnEnable()
    {
        EventRelay.Instance.SimulationEvents.PopulationAdded.Event += SpawnPopulation;
    }
    
    private void OnDisable()
    {
        if (EventRelay.Instance != null)
        {
            EventRelay.Instance.SimulationEvents.PopulationAdded.Event -= SpawnPopulation;
        }
    }

    private void SpawnPopulation(PopulationChange populationChange)
    {
        SimulationRuntime.Instance.Model.TotalPopulation += populationChange.amount;
        
        for (var i = 0; i < populationChange.amount; i++)
        {
            Instantiate(goblinPrefab, SpawnUtility.GenerateSpawnVector(), Quaternion.identity);
        }
    }
}
