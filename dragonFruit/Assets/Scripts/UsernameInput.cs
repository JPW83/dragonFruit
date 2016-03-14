using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class UsernameInput : MonoBehaviour {
    public Text nameInput;
    public string username;
    private NetworkManager networkManager;

	void Start () {
        PlayerPrefs.DeleteAll();
        networkManager = NetworkManager.FindObjectOfType<NetworkManager>();
        networkManager.gameObject.SetActive(false);
	}
	
	void Update () {
        checkUsername();
	}

    void checkUsername() {
        username = nameInput.text;
    }

    public void saveUsrName() {
        PlayerPrefs.SetString("UN", username);
    }

    public void activeNetwork() {
        networkManager.gameObject.SetActive(true);
    }
}
