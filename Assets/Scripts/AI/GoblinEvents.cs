using UnityEngine;

public class GoblinEvents : Singleton<SimulationEvents>
{
	[SerializeField] private StatusPayloadEvent mining;

	public StatusPayloadEvent Mining => mining;
}
