using UnityEngine;
using UnityEngine.UIElements;

public class InteractiveHud : MonoBehaviour
{
    private void OnEnable()
    {
        OnAddPopulationClicked();
    }

    private void OnAddPopulationClicked()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        var button = root.Q<Button>("AddPopulation");
        var counter = root.Q<Label>("TotalPopulation");

        button.clicked += () =>
        {
            
            SimulationRuntime.Instance.Model.TotalPopulation++;
            counter.text = $"Total Population: {SimulationRuntime.Instance.Model.TotalPopulation}";
            EventRelay.Instance.SimulationEvents.PopulationAdded.TriggerEvent(ConstantIds.RandomPopulation);
            // Broadcast event 
        };
    }
}
