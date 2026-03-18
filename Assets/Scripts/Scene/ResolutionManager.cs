using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;


public class ResolutionManager : MonoBehaviour
{
    [SerializeField]
	private CanvasScaler screenInfoCanvas;
    [SerializeField]
	private TextMeshProUGUI display;
    private bool isFullScreen = false;
    private UniversalRenderPipelineAsset urpAsset;


    void Awake ()
    {
        urpAsset = GraphicsSettings.currentRenderPipeline as UniversalRenderPipelineAsset;

        Screen.SetResolution(1280, 720, false);
        screenInfoCanvas.scaleFactor = 720f / 1080f;
        StartCoroutine(UpdateDisplay());
    }


    public void AdjustRenderScale(float value)
    {
        if (value == 1) {
            urpAsset.renderScale = 0.25f;
        }

        if (value == 2) {
            urpAsset.renderScale = 0.5f;
        }

        if (value == 3) {
            urpAsset.renderScale = 0.75f;
        }

        if (value == 4) {
            urpAsset.renderScale = 1.0f;
        }
    }


    public void ToggleUpscale(bool value)
    {
        if (value) {
            urpAsset.upscalingFilter = UpscalingFilterSelection.FSR;
            // urpAsset.fsrSharpness = 0.8f;
        } else {
            urpAsset.upscalingFilter = UpscalingFilterSelection.Auto;
        }
    }


    public void FullscreenSwitch(bool value)
    {
        isFullScreen = !isFullScreen;
        
        if (value)
        {
            Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
            screenInfoCanvas.scaleFactor = (float)Screen.currentResolution.height / 1080f;
        } else
        {
            Screen.SetResolution(1280, 720, false);
            screenInfoCanvas.scaleFactor = 720f / 1080f;
        }

        StartCoroutine(UpdateDisplay());
    }


    private IEnumerator UpdateDisplay()
    {
        yield return new WaitForSeconds(0.05f);
        display.SetText("Resolution" + "\n" + Screen.width + " x " + Screen.height);
    }

    void OnDisable()
    {
        urpAsset.renderScale = 1.0f;
        urpAsset.upscalingFilter = UpscalingFilterSelection.Auto;
    }
}