using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimationEventHandler : MonoBehaviour
{
    public AudioClip cardSpawnSound;

    public void PlayCardSpawnSound()
    {
        SoundEffectPlayer.Instance.PlayOneShot(cardSpawnSound);
    }
}




