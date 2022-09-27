using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Cinemachine;
public class LookAtCamera : MonoBehaviour
{
    [SerializeField] Transform cam;
    [SerializeField] GameObject camera1;
    public Camera maincam;
    public PhotonView view;
    public LookAtCamera look;
    public CinemachineFreeLook vcam;
    void Start()
    {
        
        maincam = Camera.main;
       maincam.transform.localRotation= Quaternion.Euler(0f, 90f, 0f);
        cam = maincam.transform;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine)
        {
            camera1.gameObject.SetActive(true);
            transform.localRotation = Quaternion.Euler(0f, cam.eulerAngles.y, 0f);
            vcam.m_Priority = 40;
        }
        else
        {
            vcam.m_Priority = 35;
            camera1.gameObject.SetActive(false);
        }
       
    }
}
