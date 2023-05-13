using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimationEventHandler : MonoBehaviour
{
    public AudioClip cardSpawnSound;

    public void PlayCardSpawnSound()
    {
        if (cardSpawnSound != null)
        {
            SoundEffectPlayer.Instance.PlayOneShot(cardSpawnSound);
        }
        else
        {
            Debug.LogWarning("No audio clip configured for card spawn sound.");
        }
    }
}





