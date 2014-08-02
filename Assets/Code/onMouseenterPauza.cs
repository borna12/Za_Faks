using UnityEngine;
using System.Collections;

public class onMouseenterPauza : MonoBehaviour {

    private TextMesh tm;
    private Renderer textRenderer;

    private void Start()
    {
        Screen.showCursor = true;

    }



    private void OnMouseEnter()
    {
        renderer.material.color = Color.gray;

    }

    private void OnMouseDown()
    {
        if (gameObject.name == "Backtomainmenu")
            Debug.Log("dsfsd");
            Application.Quit();
        

        if (gameObject.name == "options")
        {
            
        }


        if (gameObject.name == "Resume")
        {

            //Input.GetKeyDown(KeyCode.P) = true;

        }

        if (gameObject.name == "new_game")
        {
            Application.LoadLevel("level1");
            var glazba = GameObject.Find("main_music");



            AudioClip clip = Resources.Load("Theme") as AudioClip;
            glazba.audio.clip = clip;
            glazba.audio.Play();

        }
    }


    void OnMouseExit()
    {

        renderer.material.color = Color.red;
    }

}
