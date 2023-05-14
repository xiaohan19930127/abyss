using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimationEventHandler : MonoBehaviour
{
    public AudioClip[] cardSpawnSounds;

    public void PlayCardSpawnSound(int index)
    {
        if (index >= 0 && index < cardSpawnSounds.Length && cardSpawnSounds[index] != null)
        {
            SoundEffectPlayer.Instance.PlayOneShot(cardSpawnSounds[index]);
        }
        else
        {
            Debug.LogWarning("No audio clip configured for card spawn sound at index " + index);
        }
    }
}





