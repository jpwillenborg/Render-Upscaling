using UnityEngine;


public class ReflectionManager : MonoBehaviour
{
    [SerializeField]
    private Material objectMaterial;
    private float initialReflectionValue;
    private float initialBrightnessValue;


    void Awake()
    {
        initialReflectionValue = objectMaterial.GetFloat("_ReflectionIntensity");
        initialBrightnessValue = objectMaterial.GetFloat("_Brightness");
    }

    
    public void AdjustReflection(float value)
    {
        objectMaterial.SetFloat("_ReflectionIntensity", value);
    }


    public void AdjustBrightnessn(float value)
    {
        objectMaterial.SetFloat("_Brightness", value);
    }


    public void OnDisable()
    {
        objectMaterial.SetFloat("_ReflectionIntensity", initialReflectionValue);
        objectMaterial.SetFloat("_Brightness", initialBrightnessValue);
    }
}