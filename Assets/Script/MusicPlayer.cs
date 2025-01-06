using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    public List<AudioClip> audioClips;
    public AudioSource audioSource;
    int last = -1;
    public bool muted = false;

    void ShutTheFuckUp() {
        audioSource.volume = 0f;
    }

    void Update() {
        if (muted) {
            ShutTheFuckUp();            
        } else {
            audioSource.volume = 1f;
        }

        if (audioSource.isPlaying) {
            return;
        }

        int r = Random.Range(0, audioClips.Count);
        while (r == last) {
            r = Random.Range(0, audioClips.Count);
        }

        last = r;
        AudioClip clip = audioClips[r];
        audioSource.clip = clip;
        audioSource.Play();
    }
}
