using UnityEngine;

[System.Serializable]
public class Planet {
    public string id;
    public Vector3 center;
    public float radius = 8f;
    public float gravityStrengthMultiplier = 1f;
    public float gravityFalloffStart = 0f;
    public float gravityFalloffEnd = 0f;
}