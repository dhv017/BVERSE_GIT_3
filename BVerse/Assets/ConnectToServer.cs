using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class ConnectToServer : MonoBehaviourPunCallbacks
{

    // Start is called before the first frame update
    public InputField create;
    public InputField join;
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        Debug.Log("Joined the master");
    }
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(create.text);
        Debug.Log("Created Room");
    }
    public void JoinRoom()

    {
        PhotonNetwork.JoinRoom(join.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("MainScene");
    }

}
