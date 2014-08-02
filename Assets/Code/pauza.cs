using UnityEngine;
using System.Collections;
//[RequireComponent(typeof(AudioSource))]

public class pauza : MonoBehaviour
{

    public GameObject menu;
    void Start()
    {
        var glazba = GameObject.Find("main_music");
        if (glazba.audio.isPlaying == false)
        {
            glazba.audio.Play();
        }
    }

    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.P)==true)
        {
           
            if (Time.timeScale == 1)
            {
                
                Time.timeScale = 0;
                var glazba = GameObject.Find("main_music");
                glazba.audio.Pause();
                
                
                menu.transform.position = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width/2, Screen.height / 2));
                menu.SetActive(true);

            }
            else
            {
                Time.timeScale = 1;
                var glazba = GameObject.Find("main_music");
                glazba.audio.PlayScheduled(1);
                var meni = GameObject.Find("menu");
                menu.SetActive(false);}
            
        }
    }
}