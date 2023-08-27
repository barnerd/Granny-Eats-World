using UnityEngine;

public class MinigameAudio : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource UFOSource;
    [SerializeField] AudioSource BGSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip correctLetter;
    public AudioClip wrongLetter;
    public AudioClip fail;
    public AudioClip win;
    public AudioClip music;
    public AudioClip bubbling;

    private void Start()
    {
        BGSource.clip = bubbling;

        //MusicSource.clip = music;
        //MusicSource.Play();
    }
    
    public void PlayMusic(AudioClip clip) {
        MusicSource.PlayOneShot(clip);
        BGSource.Play();
    }
    
    public void PauseBubbling() {
        BGSource.Stop();
    }
    
    public void PauseMusic() {
        MusicSource.Stop();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}

