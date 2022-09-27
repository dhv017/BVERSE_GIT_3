using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Playerprefab;
    void Start()
    {
        //PhotonNetwork.Instantiate(Playerprefab.name, new Vector3(164.540176f, 91.0800018f, -13.8617039f), Quaternion.identity);
        //PhotonNetwork.Instantiate(Playerprefab.name, new Vector3(Random.Range(163, 170), 91.0800018f, -13.8617039f), Quaternion.identity);
        PhotonNetwork.Instantiate(Playerprefab.name, new Vector3(16.9920006f, 0.560000002f, 10.1899996f), Quaternion.identity);
       
    }

    // Update is called once per frame
    void Update()
    {

    }
}
