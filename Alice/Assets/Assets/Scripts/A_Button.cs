using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Button : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseDown()
    {
        Player pl = player.GetComponent<Player>();
        pl.moveSpeed = 100f;
    }
}
