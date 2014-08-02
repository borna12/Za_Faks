using UnityEngine;
using System.Collections;

public class sakrijTekst : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    guiText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > 1)
        {
            guiText.text = "Created by Ime";
        }
	}
}
