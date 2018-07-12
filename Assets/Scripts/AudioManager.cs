using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;
using UnityEngine.SceneManagement;


public class AudioManager : MonoBehaviour
{


    public Sound[] sounds;
    //public int muted = 0;
    public static AudioManager instance;

    // Use this for initialization

    void Start() {
        /*
        int width = 1920;
        int height = 1080;
        bool isFullscreen = false;
        int desired_fps = 60;
        

        Screen.SetResolution(width, height, isFullscreen, desired_fps);
        */
        if (SceneManager.GetActiveScene().buildIndex == 0 || 
            SceneManager.GetActiveScene().buildIndex == 9 || 
            SceneManager.GetActiveScene().buildIndex == 1 )
        {
            play("chillguitar");
        }
        if (SceneManager.GetActiveScene().buildIndex == 16)
        {
            play("guitarstrumming");
        }
        if (SceneManager.GetActiveScene().buildIndex == 16)
        {
            play("longguitarsong");
        }
        if (SceneManager.GetActiveScene().buildIndex == 16)
        {
            play("shortbeats");
        }
        if (SceneManager.GetActiveScene().buildIndex == 7 || 
            SceneManager.GetActiveScene().buildIndex == 8)
        {
            play("waiting");
        }
        if (SceneManager.GetActiveScene().buildIndex == 13 || 
            SceneManager.GetActiveScene().buildIndex == 14 || 
            SceneManager.GetActiveScene().buildIndex == 15)
        {
            play("win");
        }
        if (SceneManager.GetActiveScene().buildIndex == 10 || 
            SceneManager.GetActiveScene().buildIndex == 11 || 
            SceneManager.GetActiveScene().buildIndex == 12)
        {
            play("lose");
        }
        if (SceneManager.GetActiveScene().buildIndex == 2 || 
            SceneManager.GetActiveScene().buildIndex == 3 || 
            SceneManager.GetActiveScene().buildIndex == 4)
        {
            play("longbeats");
        }

    }

    void Awake()
    {
        if (instance == null)
            instance = this;
        else {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("sound : " + name + "not found!");
            return;
        }
        s.source.Play();
    }

    public void stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
        Debug.Log("sound was stopped");
        //switchy = 0;

    }
}
