using UnityEngine;

public class PlayMusicOnKeyPress : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Ensure that the audio does not play on awake
        audioSource.Stop();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop(); // Stop the audio if it is currently playing
            }
            else
            {
                audioSource.Play(); // Play the audio if it is not playing
            }
        }
    }
}