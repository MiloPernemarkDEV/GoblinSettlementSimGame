using UnityEngine;

public class GoblinEvents : Singleton<GoblinEvents>
{
	[SerializeField] private StatusPayloadEvent mining;

	public StatusPayloadEvent Mining => mining;
}
