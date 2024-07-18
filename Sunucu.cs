using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class Sunucu : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField RoomName;
    [SerializeField] TMP_Text RoomNameText;
    [SerializeField] TMP_Dropdown maxplayerD;
    [SerializeField] TMP_Text Error;

    private int maxplayers;

    void Start()
    {
        print("Sunucuya Bağlanılıyor");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print("Sunucuya Bağlanıldı");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        print("Lobiye Girildi");
        MenuManager.Instance.OpenMenu("Title");
    }

    public void OdaKur ()
    {
        if (string.IsNullOrEmpty(RoomName.text))
            return;
        RoomOptions roomOptions = new RoomOptions();
        if(maxplayerD.value == 0)
        {
            roomOptions.MaxPlayers = 2;
            maxplayers = 2;
        }
        if (maxplayerD.value == 1)
        {
            roomOptions.MaxPlayers = 4;
            maxplayers = 4;
        }
        PhotonNetwork.CreateRoom(RoomName.text, roomOptions, TypedLobby.Default, null);
        MenuManager.Instance.OpenMenu("Loading");
    }

    public override void OnJoinedRoom()
    {
        MenuManager.Instance.OpenMenu("RoomMenu");
        RoomNameText.text = RoomName.text + "  " +  PhotonNetwork.CountOfPlayers.ToString() + " / " + maxplayers.ToString();
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Error.text = "Oda Olustururken Bir Hata Oluştu" + message;
        MenuManager.Instance.OpenMenu("Error");
    }

    public void Odadancik ()
    {
        PhotonNetwork.LeaveRoom();
        MenuManager.Instance.OpenMenu("Loading");
    }

}
