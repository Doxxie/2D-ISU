using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public void LoadGame(string name){
        Application.LoadLevel(name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
