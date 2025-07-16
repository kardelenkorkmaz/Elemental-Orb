using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnimator : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    public void AnimateBackground()
    {
        // TODO: replace code below with animation
        particle.Play();
    }
}
