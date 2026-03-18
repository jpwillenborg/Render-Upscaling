using UnityEngine;
using TMPro;


public class FrameRateManager : MonoBehaviour
{
    public TextMeshProUGUI fpsText;
    private float currentFps;
    private float updateInterval = 0.5f;
    private float accum = 0;
    private int frames = 0;
    private float timeleft;
    private bool fps60 = true;


    void Awake()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 60;
    }


    void Start()
    {
        if (fpsText == null)
        {
            fpsText = GetComponent<TextMeshProUGUI>();
        }
        timeleft = updateInterval;
    }

    void Update()
    {
        if (Input.GetButtonDown("FPS"))
        {
            fps60 = !fps60;
            if (fps60)
            {
                QualitySettings.vSyncCount = 1;
                Application.targetFrameRate = 60;
            } else
            {
                QualitySettings.vSyncCount = 2;
                Application.targetFrameRate = 30;
            }
        }
        
        timeleft -= Time.unscaledDeltaTime;
        accum += 1.0f / Time.unscaledDeltaTime;
        ++frames;

        if (timeleft <= 0.0)
        {
            currentFps = accum / frames;
            string format = System.String.Format("{0:F2} FPS\n{1:F1} ms / frame", currentFps, 1000f / currentFps);
            if (fpsText != null)
            {
                fpsText.text = format;
            }

            timeleft = updateInterval;
            accum = 0.0f;
            frames = 0;
        }
    }
}