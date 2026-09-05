using UnityEngine;


public static class SpawnUtility
{
    public static Vector3 GenerateSpawnVector(int maxDistance, bool SpawnAtHouse = true)
    {
        if (SpawnAtHouse) return default;
        var normalized = Random.insideUnitCircle;
            
        return new Vector3(
            normalized.x * Random.Range(0, maxDistance), 
            0f, 
            normalized.y * Random.Range(0, maxDistance)
        );
    }
}