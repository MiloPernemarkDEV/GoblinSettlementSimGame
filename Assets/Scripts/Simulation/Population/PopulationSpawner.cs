using System;
using UnityEngine;

public class PopulationSpawner : MonoBehaviour
{
    [SerializeField] private GameObject goblinPrefab;
    [SerializeField] private int SpawnRadius;
    
    public void OnEnable()
    {
        EventRelay.Instance.SimulationEvents.PopulationAdded.Event += SpawnPopulation;
    }
    
    private void OnDisable()
    {
        EventRelay.Instance.SimulationEvents.PopulationAdded.Event -= SpawnPopulation;
    }

    private void SpawnPopulation(PopulationChange populationChange)
    {
        SimulationRuntime.Instance.Model.TotalPopulation += populationChange.amount;
        
        for (var i = 0; i < populationChange.amount; i++)
        {
            Instantiate(goblinPrefab, SpawnUtility.GenerateSpawnVector(SpawnRadius, false), Quaternion.identity);
        }
    }
}
