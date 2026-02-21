using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("Audio Sources")]
    public AudioSource sfxAudioSource; 
    public AudioSource musicAudioSource;

    [Header("Audio Clips")]
    public AudioClip shootSound;
    public AudioClip splashSound;

    public static SoundManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this; 
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void PlayShootSound()
    {
        sfxAudioSource.PlayOneShot(shootSound); 
    }

    public void PlaySplashSound()
    {
        sfxAudioSource.PlayOneShot(splashSound);
    }
}
