using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour {
    public List<Planet> planets = new List<Planet>();

    public (Planet planet, Vector3 gravityVec, float pull) GetStrongestPull(Vector3 pos) {
        Planet best = null;
        float bestPull = -1f;
        Vector3 bestGravity = Vector3.zero;

        foreach (var p in planets) {
            float d = Vector3.Distance(pos, p.center);
            float pull = p.gravityStrengthMultiplier / Mathf.Max(d, 0.0001f);
            if (pull > bestPull) {
                bestPull = pull;
                best = p;
                Vector3 dir = (p.center - pos).normalized;
                bestGravity = dir * (PhysicsConfigLoader.Config.planetGravityStrength * p.gravityStrengthMultiplier);
            }
        }
        return (best, bestGravity, bestPull);
    }
}