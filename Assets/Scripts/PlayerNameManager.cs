using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerNameManager : MonoBehaviour
{
    [SerializeField] InputField usernameInputField;

    private void Start()
    {
        if(PlayerPrefs.HasKey("username"))
        {
            usernameInputField.text = PlayerPrefs.GetString("username");
            PhotonNetwork.NickName = PlayerPrefs.GetString("username");
        }
        else
        {
            usernameInputField.text = "Player " + Random.Range(0, 1000).ToString("0000");
            OnUsernameValueChanged();
        }
    }

    public void OnUsernameValueChanged()
    {
        PhotonNetwork.NickName = usernameInputField.text;
        PlayerPrefs.SetString("username", usernameInputField.text);
    }
}
