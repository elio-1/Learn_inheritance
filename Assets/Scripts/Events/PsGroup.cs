using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsGroup : MonoBehaviour
{
    private ParticleSystem[] _particleSystems;
    private void Awake()
    {
        _particleSystems = GetComponentsInChildren<ParticleSystem>();
    }
    public void PlayParticleGroup()
    {
        foreach (ParticleSystem ps in _particleSystems)
        {
            ps.Play();
        }
    }
}
