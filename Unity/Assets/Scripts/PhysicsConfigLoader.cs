using System.IO;
using UnityEngine;

[System.Serializable]
public class PhysicsConfig {
    public float planetGravityStrength = 30f;
    public float gravityFalloffStart = 0f;
    public float gravityFalloffEnd = 0f;
    public float groundCheckDistance = 0.6f;
    public float walkSpeedMax = 8f;
    public float walkAcceleration = 60f;
    public float groundFriction = 12f;
    public float airControlMultiplier = 0.6f;
    public float jumpInitialImpulse = 13f;
    public float jumpHoldGravityScale = 0.6f;
    public float jumpHoldMaxTime = 0.22f;
    public bool doubleJumpAllowed = true;
    public float spinCooldown = 0.4f;
    public float spinDuration = 0.18f;
    public float spinImpulse = 6f;
    public float terminalVelocity = 40f;
    public float rotationSmoothing = 14f;
    public float cameraDistance = 10f;
    public float cameraHeight = 2f;
    public float cameraSmoothTime = 0.12f;
    public float slopeLimitDegrees = 50f;
    public float slideAcceleration = 2.5f;
    public float planetSelectionRadius = 200f;
}

public class PhysicsConfigLoader : MonoBehaviour {
    public static PhysicsConfig Config;
    void Awake() {
        string path = Path.Combine(Application.dataPath, "../CONFIG/PhysicsConfig.json");
        if (File.Exists(path)) {
            string json = File.ReadAllText(path);
            Config = JsonUtility.FromJson<PhysicsConfig>(json);
        } else {
            Config = new PhysicsConfig();
            Debug.LogWarning("PhysicsConfig.json not found; using defaults.");
        }
    }
}