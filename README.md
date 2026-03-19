# Render-Upscaling
Render scales and upscaling filters in Unity
<br><br>

![Project Image](<./.gitimages/Render Upscaling 01.png>)
<br><br>

## Project Description
This is an example with Unity's URP allowing you to adjust the render scale in conjunction with applying an upscaling filter. By default, the project's render scale is set to 1.0. When you decrease the scale you lower the target resolution, thereby lowering the strain on the GPU but making the image more pixelated. When this occurs, Unity typically by default attempts to apply one of several upscaling techniques automatically (dependent on your GPU's capabilities). By applying a combination of both techniques, it is often possible to achieve visual fidelity even when the GPU is under load. In this example, we are using AMD's FidelityFX Super Resolution (FSR) 1.0, which uses the frame buffer for upscaling.
<br>

Something to keep in mind regarding FSR, per Unity's documentation: "This filter is only supported on devices that support Unity shader model 4.5 or higher. On devices that do not support Unity shader model 4.5, Unity uses the Automatic option instead." [Unity 6.3 LTS Documentaion](https://docs.unity3d.com/6000.3/Documentation/Manual/resolution-scale-introduction.html)
<br>

Note: Some assets from the Unity Asset Store are required for a complete build. They are not included in this repo. Please see the Licenses section below for links to the assets. Otherwise, feel free to browse through the project files. Thanks.
<br><br>

## Player Controls
Move Player: WASD Keys -or- Arrows
<br>
Jump: Spacebar
<br><br>

## Project Features
* Render scale of the target resolution
* Upscaling using FSR
* Framerate counter
* Traditional baked lightmaps
* Adaptive Probe Volume for shadows
<br><br>

## Licenses
[MIT](./LICENSE)
<br>

[Pure Nature 2 : Islands](https://assetstore.unity.com/packages/3d/environments/pure-nature-2-islands-269112) by BK: Required for the main scene. Available for purchase on the Unity Asset Store. Used under the standard Unity Asset Store EULA.
<br>

[Easy Character Movement 2](https://assetstore.unity.com/packages/tools/physics/easy-character-movement-2-193614) by Oscar Gracián: Required for the main scene. Available for purchase on the Unity Asset Store. Used under the standard Unity Asset Store EULA.
<br>

[Lux URP Essentials](https://assetstore.unity.com/packages/vfx/shaders/lux-urp-essentials-150355) by forst: Required for the main scene. Available for purchase on the Unity Asset Store. Used under the standard Unity Asset Store EULA.
<br>
