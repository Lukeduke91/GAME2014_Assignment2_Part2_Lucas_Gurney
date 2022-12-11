using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class SoundManager : MonoBehaviour
{
    public List<AudioSource> channels;
    private List<AudioClip> audioClips;
    // Start is called before the first frame update
    void Awake()
    {
        channels = GetComponents<AudioSource>().ToList();
        audioClips = new List<AudioClip>();
        InitializeSoundFX();
    }

    private void InitializeSoundFX()
    {
        audioClips.Add(Resources.Load<AudioClip>("Music/inside-serial-killer39s-cove-dark-thriller-horror-soundtrack-loopable-15384"));
        audioClips.Add(Resources.Load<AudioClip>("Music/spy-always-dies-along-93740"));
        audioClips.Add(Resources.Load<AudioClip>("Music/spy-jazz-20925"));
        audioClips.Add(Resources.Load<AudioClip>("Music/war-is-coming-103662"));
    }

    public void PlaySoundFX(SoundFX sound, Channel channel)
    {
        channels[(int)channel].clip = audioClips[(int)sound];
        channels[(int)channel].Play();
    }

    public void PlayMusic()
    {
        channels[(int)Channel.MUSIC].clip = audioClips[(int)Channel.MUSIC];
        channels[(int)Channel.MUSIC].volume = 0.25f;
        channels[(int)Channel.MUSIC].loop = true;
        channels[(int)Channel.MUSIC].Play();
    }

}
