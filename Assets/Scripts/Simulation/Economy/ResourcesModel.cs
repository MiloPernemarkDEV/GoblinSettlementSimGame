using System;

public class ResourcesModel 
{
    public int Wood {get; set;}    
    public int Stone {get; set;}
    public int GoldCoin {get; set;}
    public int SilverCoin { get; set; }
    public int DarkEnergy {get; set;}

    public void Change(ResourceType resourceType, ResourceAction resourceAction, int amount)
    {
        switch (resourceAction)
        {
            case ResourceAction.Add: Add(resourceType, amount); 
                break;
            case ResourceAction.Trade:
            case ResourceAction.Use: Use(resourceType, amount); 
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(resourceAction), resourceAction, null);
        }

        if (resourceAction == ResourceAction.Trade)
        {
            // Trade event 

            return;
        }
        
        EventRelay.Instance.ResourceEvents.ResourceActionHappened.Ping(
            new ResourceChange
            {
                ResourceType = resourceType,
                ResourceAction =  resourceAction,
                Amount = amount
            }
        );
    }

    private void Use(ResourceType resourceType, int amount)
    {
        switch (resourceType)
        {
            case ResourceType.GoldCoin: GoldCoin -= amount; break;
            case ResourceType.SilverCoin: SilverCoin -= amount; break;
            case ResourceType.Stone: Stone -= amount; break;
            case ResourceType.Wood: Wood -= amount; break;
            case ResourceType.DarkEnergy: DarkEnergy -= amount; break;

            default:
                throw new ArgumentOutOfRangeException(nameof(resourceType), resourceType, null);
        }
    }
    
    private void Add(ResourceType resourceType, int amount)
    {
        switch (resourceType)
        {
            case ResourceType.GoldCoin: GoldCoin += amount; break;
            case ResourceType.SilverCoin: SilverCoin += amount; break;
            case ResourceType.Stone: Stone += amount; break;
            case ResourceType.Wood: Wood += amount; break;
            case ResourceType.DarkEnergy: DarkEnergy += amount; break;

            default:
                throw new ArgumentOutOfRangeException(nameof(resourceType), resourceType, null);
        }
    }
    
    
}
