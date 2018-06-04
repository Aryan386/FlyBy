﻿using UnityEngine;
using UnityEngine.EventSystems;


public class SelectInputIO : MonoBehaviour {

    public EventSystem eventSystem;
    public GameObject selectObject;
    private bool buttonSelected;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxisRaw ("Vertical") != 0 && buttonSelected == false)
        {
            eventSystem.SetSelectedGameObject(selectObject);
            buttonSelected = true;
        }

	}

    private void OnDisable()
    {
        buttonSelected = false;
    }
}
