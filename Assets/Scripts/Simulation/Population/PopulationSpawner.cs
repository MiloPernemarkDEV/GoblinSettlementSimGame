using System;
using UnityEngine;

public class PopulationSpawner : MonoBehaviour
{
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

    void SpawnPopulation(PopulationChange populationChange)
    {
        SimulationRuntime.Instance.Model.TotalPopulation += populationChange.amount;
        Debug.Log("Spawning " + populationChange.Id);
        Debug.Log($"Total Population: {SimulationRuntime.Instance.Model.TotalPopulation}");
        
        //Spawn(AIFactory(populationChange.Id)) 
    }
}
