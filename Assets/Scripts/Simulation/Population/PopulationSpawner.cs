using UnityEngine;

public class PopulationSpawner : MonoBehaviour
{
    public void OnEnable()
    {
        EventRelay.Instance.SimulationEvents.PopulationAdded.OnEventTriggered += SpawnPopulation;
    }
    
    private void OnDisable()
    {
        if (EventRelay.Instance != null)
        {
            EventRelay.Instance.SimulationEvents.PopulationAdded.OnEventTriggered -= SpawnPopulation;
        }
    }

    void SpawnPopulation(string populationId)
    {
        Debug.Log("Spawning " + populationId);
        Debug.Log($"Total Population: {SimulationRuntime.Instance.Model.TotalPopulation}");
    }
    
}
