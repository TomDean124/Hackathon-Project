using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("Audio Sources")]
    public AudioSource _sfxAudioSource; 
    public AudioSource _musicAudioSource;

    [Header("Audio Clips")]
    public AudioClip[] walkingSounds;

    [Header("Mu")]

    private float m_walkTimer;
    private float intervalBetweenWalkSounds = 3f; 

    public void PlaySound(AudioClip _clip)
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            m_walkTimer += Time.deltaTime;
            if(m_walkTimer >= intervalBetweenWalkSounds)
            {
                int _randomNum = Random.Range(0, walkingSounds.Length);
                if(walkingSounds[_randomNum] != null)
                {
                    _sfxAudioSource.PlayOneShot(walkingSounds[_randomNum]);
                }
            }

        }
        _sfxAudioSource.PlayOneShot(_clip); 
    }
}
