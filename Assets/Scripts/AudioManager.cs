using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip lightSwitchSFX;
    [SerializeField] AudioClip ambientSFX;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(ambientSFX);
    }


    public void PlayLightSwitchClick()
    {
        audioSource.PlayOneShot(lightSwitchSFX);
    }
}
