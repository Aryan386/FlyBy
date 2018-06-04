
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadscreenOnClick : MonoBehaviour {

	public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);

    }
}
