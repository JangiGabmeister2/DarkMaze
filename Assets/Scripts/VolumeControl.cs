using UnityEngine;

public enum VolumeSetting
{
    sfx,
    music
}

public class VolumeControl : MonoBehaviour
{
    public PlateControl[] plates;

    [SerializeField] private VolumeSetting _vol;

    private void Update()
    {
        for (int i = 0; i < plates.Length; i++)
        {
            if (plates[i].isOn)
            {
                SetVolume(plates[i].volumeValue);
            }
        }
    }

    private void SetVolume(float volume)
    {
        if (_vol == VolumeSetting.sfx)
        {
            SoundMaster.Instance.MuteSFX(false);
            SoundMaster.Instance.SFXVolume(volume);
        }
        else if (_vol == VolumeSetting.music)
        {
            SoundMaster.Instance.MuteMusic(false);
            SoundMaster.Instance.MusicVolume(volume);
        }
    }
}
