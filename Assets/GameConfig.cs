using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfig : MonoBehaviour {

    // Use this for initialization

    public int choosedCharacter;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

    }
}
