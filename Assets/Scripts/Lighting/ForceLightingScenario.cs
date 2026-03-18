using UnityEngine;
using UnityEngine.Rendering;


public class ForceLightingScenario : MonoBehaviour
{
    private string scenario = "Default";
    private ProbeReferenceVolume probeRefVolume;
    

    void Start()
    {
        probeRefVolume = ProbeReferenceVolume.instance;
        probeRefVolume.BlendLightingScenario(scenario, 0.0f);
    }
}