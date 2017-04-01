using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionSound : MonoBehaviour
{
    public List<AudioClip> painClips = new List<AudioClip>();
    public List<AudioClip> deathClips = new List<AudioClip>();
    public List<AudioClip> ambientClips = new List<AudioClip>();
    public AudioSource audio;

    private float nextActionTime = 0.0f;
    private float period = 5.0f;

    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            playClip(ambientClips);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerShot")
        {
            playClip(painClips);
        }
    }

    void OnDestroy()
    {
        int numPain = Random.Range(0, 4);
        playClip(deathClips);
    }

    private void playClip(List<AudioClip> clips)
    {
        if (audio)
        {
            int num = Random.Range(0, clips.Count);
            audio.clip = clips[num];
            audio.Play();
        }
    }
}
