using UnityEngine;
using System.Collections;

public class points : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        TextMesh point = (TextMesh)GetComponent(typeof(TextMesh));
        point.text = string.Format("Points:{0}", gamemanager.Instance.Points);
	
	}
}
