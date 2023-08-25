using UnityEngine;

public class ShopAudio : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource UFOSource;
    [SerializeField] AudioSource BGSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip ballSound;
    //public AudioClip shopMusic;

    private void Start()
    {
        //BGSource.clip = ambiance;
        //BGSource.Play();

        //MusicSource.clip = shopMusic;
        //MusicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
