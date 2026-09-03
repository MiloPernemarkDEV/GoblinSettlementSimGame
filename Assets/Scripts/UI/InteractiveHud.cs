using UnityEngine;
using UnityEngine.UIElements;

public class InteractiveHud : MonoBehaviour
{
    private VisualElement root;
    
    private Button addPopulationButton;
    
    private Label totalPopulationLabel;
    private Label addPopulationPopupLabel;
    
    private void OnEnable()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        
        addPopulationButton = root.Q<Button>("add-population-button");
        totalPopulationLabel = root.Q<Label>("total-population-label"); 
        addPopulationPopupLabel = root.Q<Label>("add-population-popup-label");

        if (addPopulationButton == null)
        {
            Debug.LogError("Add population button is missing");
        }
        
        if (addPopulationPopupLabel == null)
        {
            Debug.LogError("Add population popup label is missing");
        }
        
        if (totalPopulationLabel == null)
        {
            Debug.LogError("Total population label is missing");
        }
        
            
        OnAddPopulationClicked();
        EventRelay.Instance.SimulationEvents.PopulationAdded.Event += OnPopulationAdded;
    }
    
    private void OnAddPopulationClicked()
    {
        addPopulationButton.clicked += () =>
        {
            EventRelay.Instance.SimulationEvents.PopulationAdded.Ping(
                new PopulationChange
                {
                    Id = ConstantIds.PeasantGoblin,
                    amount = 5
                }
            );
        };
    }

    private void OnPopulationAdded(PopulationChange populationChange)
    {
        totalPopulationLabel.text = $"Total Population: {SimulationRuntime.Instance.Model.TotalPopulation}";
        addPopulationPopupLabel.text = "Spawned +1 " + ConstantIds.ToDisplayName(populationChange.Id);
    }
}
