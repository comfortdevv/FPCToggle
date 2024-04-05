using BepInEx;
using Photon.Pun;
using UnityEngine;

namespace Main
{
    [BepInPlugin("com.comfortdev.fpctoggle", "fpctoggle", "1.0.0")]
    public class Main : BaseUnityPlugin
    {
        private bool showGui = true;
        private GameObject? thirdPersonCamera;

        void Start()
        {
            thirdPersonCamera = GameObject.Find("Player Objects/Third Person Camera");
        }


        void OnGUI()
        {
            if (showGui)
            {
                if (GUI.Button(new Rect(20, 40, 130, 30), "Toggle FPC")) 
                {
                    if (thirdPersonCamera != null)
                    {
                        thirdPersonCamera.SetActive(!thirdPersonCamera.activeSelf);
                    }
                }
            }
        }
    }
}
