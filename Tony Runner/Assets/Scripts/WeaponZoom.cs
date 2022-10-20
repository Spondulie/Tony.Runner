using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 30f;
    [SerializeField] float zoomedOutSensitivity = 2f;
    [SerializeField] float zoomedInSensitivity = 0.5f;

    FirstPersonController fpsController;

    bool zoomedInToggle = false;

    void Start()
    {
        fpsController = GetComponent<FirstPersonController>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
                fpsController.m_MouseLook.XSensitivity = zoomedInSensitivity;
                fpsController.m_MouseLook.YSensitivity = zoomedInSensitivity;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
                fpsController.m_MouseLook.XSensitivity = zoomedOutSensitivity;
                fpsController.m_MouseLook.YSensitivity = zoomedOutSensitivity;
            }
        }
    }
}
