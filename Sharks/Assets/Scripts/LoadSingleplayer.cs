using UnityEngine;
using System.Collections;

public class LoadSingleplayer : MonoBehaviour {

	public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }
}
