using UnityEngine;
using System.Collections;
//[RequireComponent(typeof(AudioSource))]

public class pauza : MonoBehaviour
{
    public string[] items;
    public string slectedItem = "None   ";
    private Rect windowRect;
    private bool editing = true;
    private bool editing2 = true;


    private void Start()
    {
        windowRect = new Rect(Screen.width/2 - 100, Screen.height/2 - 100, 200, 100);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) == true || Input.GetKeyDown(KeyCode.Escape) == true)
        {

            if (Time.timeScale == 1)
            {

                Time.timeScale = 0;
                var glazba = GameObject.Find("main_music");
                glazba.audio.Pause();
                var igrac = GameObject.Find("igrac");
                igrac.GetComponent<igrac>().enabled = false;

            }
            else
            {
                Time.timeScale = 1;
                var glazba = GameObject.Find("main_music");
                glazba.audio.PlayScheduled(1);
                var igrac = GameObject.Find("igrac");
                igrac.GetComponent<igrac>().enabled = true;


            }
        }
    }




    private void OnGUI()
    {
        if (Time.timeScale == 0)
            windowRect = GUI.Window(0, windowRect, windowFunc, "Pause Menu");

        if(editing==false)
            windowRect = GUI.Window(0, windowRect, windowFunc2, "Options Menu");
        if (editing2 == false)
            windowRect = GUI.Window(0, windowRect, windowFunc3, "Sound Menu");
    }

    private void windowFunc(int id)
    {
        if (GUILayout.Button("Resume"))
        {
            Time.timeScale = 1;
            var glazba = GameObject.Find("main_music");
            glazba.audio.PlayScheduled(1);
            var igrac = GameObject.Find("igrac");
            //igrac.GetComponent<kontrolerzalika>().enabled = true;
            igrac.GetComponent<igrac>().enabled = true;
        }





        if (GUILayout.Button("Options"))
        {
            editing = false;
        }

         
            if (GUILayout.Button("Quit"))
            {
                Application.Quit();

            }
    }

    private void windowFunc2(int id)
    {
        if (GUILayout.Button("Sound"))
        {
            editing2 = false;
        }
        if (GUILayout.Button("Controles"))
        {
        }
        if (GUILayout.Button("Back"))
        {
            editing = true;
        }
    }

    private void windowFunc3(int id)
    {
        GUILayout.Label("Main Music");
        var glazba = GameObject.Find("main_music");

        glazba.audio.volume=GUILayout.HorizontalSlider(glazba.audio.volume, 0f, 1f);
       
        if (GUILayout.Button("Back"))
        {
            editing2 = true;
        }
    }
}