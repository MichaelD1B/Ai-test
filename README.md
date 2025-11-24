# Super Wario Galaxy Movement Prototype

This is a movement-first educational prototype reproducing the feel of Super Mario Galaxy's spherical planetoid gravity, tight platforming jumps, variable jump height, spin attack, surface alignment, and responsive camera.

Only implements movement, collisions, camera, debug UI, and one demo level. No menus, no copyrighted assets.

## Engines

- Unity (recommended): Open Unity/ in Unity Editor 2020.3+, open Scenes/Demo.unity, press play.
- Godot: Open Godot/ project.godot, run demo.tscn.
- Web: Open Web/index.html in browser.

## Playtest Checklist

1. Launch the demo scene.
2. Move forward toward the medium planet; observe gravity vector in the debug overlay.
3. Run full forward input for 2 seconds — confirm velocity reaches walkSpeedMax within ~0.35s.
4. Jump short (tap) and record apex height; jump long (hold) and verify apex >= short * 1.25.
5. Use spin on enemy cube — it should break and bounce you slightly.
6. Travel from small planet to medium planet via ramp — verify rotation smoothing does not snap.

## Tuning Guide

- walkAcceleration (20–140): higher → snappier start/stop.
- walkSpeedMax (4–12): top speed.
- jumpInitialImpulse (8–18): initial vertical velocity.
- jumpHoldGravityScale (0.25–1.0): lower → bigger hold effect.
- rotationSmoothing (4–24): lower → snappier rotation.
- cameraSmoothTime (0.04–0.4): lower → tighter camera.

Top parameters for Mario Galaxy feel:
1. Increase rotationSmoothing from 14 → 16
2. Reduce airControlMultiplier to 0.45
3. Increase jumpHoldGravityScale to 0.7
4. Reduce walkAcceleration to 50
5. Increase cameraSmoothTime to 0.15