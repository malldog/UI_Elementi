using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AinuParsledzejs : MonoBehaviour {
    public void UzSakumu() {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }
    public void Apturet() {
        Application.Quit();
    }
    public void UzAinu() {
        SceneManager.LoadScene("UIelementi", LoadSceneMode.Single);
            }
}
