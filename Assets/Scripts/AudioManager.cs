using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
   [SerializeField] AudioSource MusicSource;
   [SerializeField] AudioSource UFOSource;
   [SerializeField] AudioSource BGSource;
   [SerializeField] AudioSource CricketsSource;
   [SerializeField] AudioSource SFXSource;

   [Header("---------- Audio Clip ----------")]
   public AudioClip Track01;
   public AudioClip Track02;
   public AudioClip melody01;
   public AudioClip melody02;
   public AudioClip melody03;
   public AudioClip melody04;
   public AudioClip ambiance;
   public AudioClip crickets; 
   public AudioClip idleUFO;

   private void Start()
   {
        BGSource.clip = ambiance;
        CricketsSource.clip = crickets;
        UFOSource.clip = idleUFO;
        MusicSource.clip = Track02;
        MusicSource.Play();
        UFOSource.Play();
        CricketsSource.Play();
        BGSource.Play();
   }

   public void PlaySFX(AudioClip clip)
   {
        SFXSource.PlayOneShot(clip);
   }



}
