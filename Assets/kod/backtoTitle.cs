using UnityEngine;
using System.Collections;

public class backtoTitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.LoadLevel("title");
            var glazba = GameObject.Find("One shot audio");
            DestroyObject(glazba);
        }
	}
}
