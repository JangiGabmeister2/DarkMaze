using System;
using UnityEngine;

public class SoundMaster : MonoBehaviour
{
    #region Singleton
    public static SoundMaster Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Start()
    {
        musicSource.mute = false;
        sfxSource.mute = false;

        PlayMusic("Theme");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, s => s.name == name);

        if (s == null)
        {
            Debug.Log("Sound not found.");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, s => s.name == name);

        if (s == null)
        {
            Debug.Log("Sound not found.");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public AudioClip GetSoundClip(string name)
    {
        Sound s = Array.Find(sfxSounds, s => s.name == name);

        if (s != null)
        {
            return s.clip;
        }
        else
        {
            return null;
        }
    }

    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }

    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
    }

    public void MuteMusic(bool b)
    {
        musicSource.mute = b;
    }

    public void MuteSFX(bool b)
    {
        sfxSource.mute = b;
    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }

}

[Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
}