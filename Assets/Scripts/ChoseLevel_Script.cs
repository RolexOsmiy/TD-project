using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoseLevel_Script : MonoBehaviour {
    
    public static bool Open = false;

    public void LoadThisLevel()
    {
        if (MainMenu_script.CurrLevel + 1 >= int.Parse(this.gameObject.name))
        {
            SceneManager.LoadScene(sceneBuildIndex: (int.Parse(this.gameObject.name)));
        }
    }
}
