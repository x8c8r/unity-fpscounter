using System;
using BepInEx;
using UnityEngine;

namespace FPSCounter
{
    [BepInPlugin("xyz.fl1pnatic.monofpscounter", "FPS Counter", "1.0.0.0")]
    public class Main : BaseUnityPlugin
    {

        public void Start()
        {
            Debug.Log("Loaded FPS Counter!");
        }

        public void OnGUI()
        {
            float fps = 1 / Time.unscaledDeltaTime;
            GUI.Label(new Rect(Screen.width - Screen.width + 10, Screen.height - Screen.height + 20, 100, 200), "FPS: " + fps);
        }
    }
}