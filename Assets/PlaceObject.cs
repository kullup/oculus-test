using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    private ParticleSystem particleSystem;

    private void Start()
    {
        // Get the Particle System component attached to this GameObject
        particleSystem = GetComponent<ParticleSystem>();
        var emission = particleSystem.emission;
        emission.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Activate the emission of the Particle System when the collider starts intersecting with another collider
        var emission = particleSystem.emission;
        emission.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        // Deactivate the emission of the Particle System when the collider stops intersecting with another collider
        var emission = particleSystem.emission;
        emission.enabled = false;
    }
}