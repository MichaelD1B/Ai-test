using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody rb;
    private PlanetManager planetManager;

    void Start() {
        planetManager = FindObjectOfType<PlanetManager>();
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // Custom gravity
    }

    void FixedUpdate() {
        // Get strongest gravity
        var (planet, gravityVec, pull) = planetManager.GetStrongestPull(transform.position);

        // Apply gravity as acceleration
        rb.AddForce(gravityVec, ForceMode.Acceleration);

        // Debug visualization
        if (planet != null) {
            Debug.DrawLine(transform.position, transform.position + gravityVec.normalized * 5f, Color.red);
        }
    }

    void OnGUI() {
        var (planet, gravityVec, pull) = planetManager.GetStrongestPull(transform.position);
        if (planet != null) {
            GUI.Label(new Rect(10, 10, 300, 20), $"Current Planet ID: {planet.id}, Gravity Magnitude: {gravityVec.magnitude:F2}");
        }
    }
}